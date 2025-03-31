import React from "react";
import styles from "./HomeComp.module.css";
import Image from "next/image";

function HeroSection() {
  return (
    <section className={styles.hero}>
      <div className={styles.hero__container}>
        <div className={styles.hero__left}>
          <div className={styles.hero__title}>
            <span className={styles.hero__titleMain}>The Fastest</span>
            <div className={styles.hero__titleWithIcon}>
              <span>Pizza</span>
              <Image
                src="/icons/Lightning.png"
                alt="Lightning icon"
                width={50}
                height={50}
              />
              <span>Delivery</span>
            </div>
          </div>
          <p className={styles.hero__description}>
            We will deliver juicy pizza for your family in 30 minutes, if the
            courier is late -{" "}
            <span className={styles.hero__descriptionHighlight}>pizza is free!</span>
          </p>
          <div className={styles.hero__process}>
            <span>Cooking process </span>
            <Image
              src="/images/HomeComp1.png"
              alt="Cooking process"
              className={styles.hero__processImage}
              width={272}
              height={193}
            />
          </div>
          <div className={styles.hero__cta}>
            <div className={styles.hero__buttons}>
              <button className={styles.hero__buttonPrimary}>To order</button>
              <button className={styles.hero__buttonSecondary}>
                <span className={styles.hero__buttonText}>Pizza-Menu</span>
              </button>
            </div>
          </div>
        </div>
        <div className={styles.hero__right}>
          <Image
            src="/images/HomeComp2.png"
            alt="Pizza delivery"
            className={styles.hero__mainImage}
            width={456}
            height={684}
          />
          <Image
            src="/icons/fries.png"
            alt="French fries"
            className={styles.hero__decorationFries}
            width={212}
            height={226}
          />
          <Image
            src="/icons/pizza.png"
            alt="Pizza"
            className={styles.hero__decorationPizza}
            width={252}
            height={252}
          />
        </div>
      </div>
    </section>
  );
}

export default HeroSection;