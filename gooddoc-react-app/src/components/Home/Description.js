import "./Description.css";

export const Description = () => {
  return (
    <section className="desc-section">
      <div className="desc-container">
        <img
          alt="doctor"
          className="desc-img-doctor"
          src="https://www.hopestandard.com/wp-content/uploads/2023/01/31628750_web1_Doctor_stock-dr.jpg"
        />
        <div className="desc-box">
          <h5 className="desc-small-title">
            GoodDoc осигурява необходимата помощ
          </h5>
          <h1 className="desc-title">
            Желаете ли бързо записване на час при избрания от вас специалист?
          </h1>
          <ul className="desc-ul-list">
            <li className="desc-li-element">
              Потърсете бързо необходимия лекар във вашата област
            </li>
            <li className="desc-li-element">
              Разгледайте ревютата на други пациенти
            </li>
            <li className="desc-li-element">
              Запишете медицински преглед веднага
            </li>
          </ul>
        </div>
      </div>
    </section>
  );
};
