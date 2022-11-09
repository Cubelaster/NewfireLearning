import React from 'react';
import './App.css';
import { BrowserRouter as Router } from 'react-router-dom';
import AppLayout from './components/layouts/layout';

const App = () => {
  return (
    <Router>
      <AppLayout />
    </Router>
  );
};

export default App;
