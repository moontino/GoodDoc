import { Header } from "./Header";
import { Main } from "./Main";
import { Description } from "./Description";
import "./Home.css";

export const Home = () => {
  return (
    <div className="home-layer">
      <Header />
      <Main />
      <Description />
    </div>
  );
};
