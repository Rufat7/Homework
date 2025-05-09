import type React from "react"
import { getDictionary } from "../dictionaries"

export async function generateStaticParams() {
  return [{ lang: "ru" }, { lang: "en" }, { lang: "fr" }]
}

export default async function RootLayout({
  children,
  params,
}: {
  children: React.ReactNode
  params: { lang: string }
}) {
  const dict = await getDictionary(params.lang)

  return (
    <html lang={params.lang}>
      <body>
        <header>
          <nav>
            <ul className="flex gap-4 p-4 bg-gray-100">
              <li>
                <a href={`/${params.lang}`}>{dict.navigation.home}</a>
              </li>
              <li>
                <a href={`/${params.lang}/about`}>{dict.navigation.about}</a>
              </li>
              <li>
                <a href={`/${params.lang}/contact`}>{dict.navigation.contact}</a>
              </li>
            </ul>
          </nav>
        </header>
        <main className="container mx-auto p-4">{children}</main>
      </body>
    </html>
  )
}
