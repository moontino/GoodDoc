import styles from "./Header.module.css";

export const Header = () => {
  return (
    <header className={styles.header}>
      <h1 className={styles.logo}>GoodDoc</h1>
      <input className={styles["nav-toggle"]} id="nav-toggle" type="checkbox" />
      <nav className={styles.nav}>
        <ul className={styles["ul-list"]}>
          <li className={styles["li-element"]}>
            <a className={styles.link} href="/#">
              Data
            </a>
          </li>
          <li className={styles["li-element"]}>
            <a className={styles.link} href="/#">
              Something
            </a>
          </li>
          <li className={styles["li-element"]}>
            <a className={styles.link} href="/#">
              News
            </a>
          </li>
          <li className={styles["li-element"]}>
            <a className={styles.link} href="/#">
              Profil
            </a>
          </li>
        </ul>
      </nav>
      <label className={styles["nav-toggle-label"]}>
        <span className={styles["closed-span"]}></span>
      </label>
    </header>
  );
};
