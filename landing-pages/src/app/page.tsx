import Hero from "@/components/hero"
import TrustedCompanies from "@/components/trusted-companies"
import Navbar from "@/components/navbar"
import Footer from "@/components/footer"
import About from "@/components/about"
import FurnitureShowcase from "@/components/furniture-showcase"
import FurnitureFilter from "@/components/furniture-filter"

export default function Home({ children }: { children: React.ReactNode }) {
  return (
    <div className="min-h-screen flex flex-col">
      <Navbar />
      <Hero />
      <TrustedCompanies />
      <About />
      <FurnitureShowcase />
      <FurnitureFilter />
      <Footer />
    </div>
  )
}

