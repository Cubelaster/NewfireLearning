import React from 'react';
import {
  createBrowserRouter,
  createRoutesFromElements,
  Navigate,
  Route,
} from 'react-router-dom';
import AppLayout from '../components/layouts/layout';
import About from '../pages/about';
import ApiTest from '../pages/apiTest';
import Callback from '../pages/callback';
import Dashboard from '../pages/dashboard';
import {
  ErrorPage,
  FourOhFour,
  FourOhOne,
  FourOhThree,
} from '../pages/statusPages';
import PrivateRoute from './privateRoute';

const router = createBrowserRouter(
  createRoutesFromElements(
    <Route path='/' element={<AppLayout />} errorElement={<ErrorPage />}>
      <Route path='/about' element={<About />} />
      <Route path='/callback' element={<Callback />} />
      <Route path='/dashboard' element={<Dashboard />} />
      <Route element={<PrivateRoute />}>
        <Route path='/private' element={<ApiTest />} />
      </Route>
      <Route path='/401' element={<FourOhOne />} />
      <Route path='/403' element={<FourOhThree />} />
      <Route path='/404' element={<FourOhFour />} />
      <Route path='*' element={<Navigate to='/404' />} />
    </Route>
  )
);

export default router;
