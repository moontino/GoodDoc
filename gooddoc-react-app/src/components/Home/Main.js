import styles from "./Main.module.css";
import { useState, useEffect } from "react";

export const Main = () => {
  //Най-вероятно ще дойдат данните от Home/App
  const [specialty, setSpecialty] = useState([]);

  useEffect(() => {
    fetch("https://localhost:7287/api/Search")
      .then((res) => res.json())
      .then((result) => setSpecialty(result));
  });
  ///* disabled */ при напискане на селект листа трябва да се сложах
  // line styles за да изчезне ИЗБАНАТА опция
  return (
    <section className={styles["search-section"]}>
      <label className={styles["search-doc"]}>Търси лекар</label>
      <div className={styles.container}>
        <select className={`${styles.select} ${styles.specialty}`}>
          <option key="0" className={styles.option}>
            Избери специалност
          </option>

          {specialty.map((x) => (
            <option key={x.id} className={styles.option}>
              {x.name}
            </option>
          ))}
        </select>
        <select className={`${styles.select} ${styles.place}`}>
          <option disabled value="" hidden className={styles.placeholder}>
            Избери населено място
          </option>
          <option className={styles.option}>Something 2</option>
        </select>
        <select className={`${styles.select} ${styles.name}`}>
          <option disabled value="" hidden className={styles.placeholder}>
            Намери лекар по име...
          </option>
          <option className={styles.option}>Something 3</option>
        </select>
      </div>
      <button className={styles["btn-search"]}>Търси</button>
      <img
        alt="doctor"
        className={styles["doctor-img"]}
        src="https://merriam-webster.com/assets/mw/images/article/art-wap-landing-mp-lg/alt-5ae892611bf1a-5168-1472832016f2509f3889266323039a33@1x.jpg"
      />
    </section>
  );
};
