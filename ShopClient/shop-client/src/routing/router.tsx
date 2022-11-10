import React from 'react';
import {
  createBrowserRouter,
  createRoutesFromElements,
  Route,
} from 'react-router-dom';
import ErrorPage from '../pages/statusPages/errorPage';
import AppLayout from '../components/layouts/layout';
import About from '../pages/about';
import Callback from '../pages/callback';
import Dashboard from '../pages/dashboard';
import PrivateRoute from './privateRoute';

const router = createBrowserRouter(
  createRoutesFromElements(
    <Route path='/' element={<AppLayout />} errorElement={<ErrorPage />}>
      <Route path='/about' element={<About />} />
      <Route path='/callback' element={<Callback />} />
      <Route path='/dashboard' element={<Dashboard />} />
      <Route element={<PrivateRoute />}>
        <Route path='/private' element={<div>Private</div>} />
      </Route>
      <Route path='/401' element={<div>You need to login</div>} />
      <Route path='/403' element={<div>You don't have permission</div>} />
    </Route>
  )
);

export default router;
