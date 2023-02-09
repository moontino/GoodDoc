import styles from "./Description.module.css";

export const Description = () => {
  return (
    <section className={styles["desc-section"]}>
      <div className={styles["desc-container"]}>
        <img
          alt="doctor"
          className={styles["desc-img-doctor"]}
          src="https://www.hopestandard.com/wp-content/uploads/2023/01/31628750_web1_Doctor_stock-dr.jpg"
        />
        <div className={styles["desc-box"]}>
          <h5 className={styles["desc-small-title"]}>
            GoodDoc осигурява необходимата помощ
          </h5>
          <h1 className={styles["desc-title"]}>
            Желаете ли бързо записване на час при избрания от вас специалист?
          </h1>
          <ul className={styles["desc-ul-list"]}>
            <li className={styles["desc-li-element"]}>
              Потърсете бързо необходимия лекар във вашата област
            </li>
            <li className={styles["desc-li-element"]}>
              Разгледайте ревютата на други пациенти
            </li>
            <li className={styles["desc-li-element"]}>
              Запишете медицински преглед веднага
            </li>
          </ul>
        </div>
      </div>
    </section>
  );
};
