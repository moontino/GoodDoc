import "./Header.css";

export const Header = () => {
  return (
    <header className="header">
      <h1 className="logo">GoodDoc</h1>
      <input className="nav-toggle" id="nav-toggle" type="checkbox" />
      <nav className="nav">
        <ul className="ul-list">
          <li className="li-element">
            <a className="link" href="/#">
              Data
            </a>
          </li>
          <li className="li-element">
            <a className="link" href="/#">
              Something
            </a>
          </li>
          <li className="li-element">
            <a className="link" href="/#">
              News
            </a>
          </li>
          <li className="li-element">
            <a className="link" href="/#">
              Profil
            </a>
          </li>
        </ul>
      </nav>
      <label class="nav-toggle-label" for="nav-toggle">
        <span className="closed-span"></span>
      </label>
    </header>
  );
};
