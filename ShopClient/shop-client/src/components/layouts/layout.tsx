import React from 'react';
import { BrowserRouter as Router, Link } from 'react-router-dom';
import Routing from '../../routing/routing';

const Layout = () => (
  <Router>
    <nav>
      <ul>
        <li>
          <Link to='/'>Dashboard</Link>
        </li>
        <li>
          <Link to='/callback'>Callback</Link>
        </li>
        <li>
          <Link to='/about'>About</Link>
        </li>
      </ul>
    </nav>
    <Routing />
  </Router>
);

export default Layout;
