import React from 'react';
import { Routes, Route } from 'react-router-dom';
import About from '../pages/about';
import Callback from '../pages/callback';
import Dashboard from '../pages/dashboard';

const Routing = () => (
  <Routes>
    <Route path='/about' element={<About />} />
    <Route path='/callback' element={<Callback />} />
    <Route path='/dashboard' element={<Dashboard />} />
    <Route path='/' element={<Dashboard />} />
  </Routes>
);

export default Routing;
