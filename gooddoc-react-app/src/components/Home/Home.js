import { Header } from "./Header";
import { Main } from "./Main";
import { Description } from "./Description";
import styles from "./Home.module.css";

export const Home = () => {
  return (
    <div className={styles["home-layer"]}>
      <Header />
      <Main />
      <Description />
    </div>
  );
};
