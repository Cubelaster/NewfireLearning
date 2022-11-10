import React from 'react';
import { RouterProvider } from 'react-router-dom';
import './App.css';
import { AppConfigContextProvider } from './contexts/appConfigContext';
import router from './routing/router';

const App = () => {
  return (
    <AppConfigContextProvider>
      <RouterProvider router={router} />;
    </AppConfigContextProvider>
  );
};

export default App;
