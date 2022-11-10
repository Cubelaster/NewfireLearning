import React from 'react';
import { RouterProvider } from 'react-router-dom';
import './App.css';
import { AppConfigContextProvider } from './contexts/appConfigContext';
import { AuthContextProvider } from './contexts/authContext';
import router from './routing/router';

const App = () => {
  return (
    <AppConfigContextProvider>
      <AuthContextProvider>
        <RouterProvider router={router} />;
      </AuthContextProvider>
    </AppConfigContextProvider>
  );
};

export default App;
