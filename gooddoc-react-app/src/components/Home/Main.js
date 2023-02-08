import "./Main.css";

export const Main = () => {
  return (
    <section className="search-section">
      <label className="search-doc">Търси лекар</label>
      <div className="container">
        <select className="select specialty">
          <option disabled selected hidden className="placeholder">
            Избери специалност
          </option>
          <option className="option">Something</option>
        </select>
        <select className="select place">
          <option disabled selected hidden className="placeholder">
            Избери населено място
          </option>
          <option className="option">Something 2</option>
        </select>
        <select className="select name">
          <option disabled selected hidden className="placeholder">
            Намери лекар по име...
          </option>
          <option className="option">Something 3</option>
        </select>
      </div>
      <button className="btn-search">Търси</button>
      <img
        alt="doctor"
        className="doctor-img"
        src="https://merriam-webster.com/assets/mw/images/article/art-wap-landing-mp-lg/alt-5ae892611bf1a-5168-1472832016f2509f3889266323039a33@1x.jpg"
      />
    </section>
  );
};
