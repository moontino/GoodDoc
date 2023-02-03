import logo from './logo.svg';
import './App.css';
import React, { useEffect, useState } from "react";

function App() {
  const [user, setUser] = useState([]);

  const fetchData = () => {
    return fetch("https://localhost:7287/api/Test")
          .then((response) => response.json())
          .then((data) => setUser(data));
  }
console.log(user);
console.log(setUser)
  useEffect(() => {
    fetchData();
  },[])

  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn Reactv
        </a>
      </header>
    </div>
  );
}

export default App;
