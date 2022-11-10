import React, { useContext, useEffect } from 'react';
import AuthContext from '../contexts/authContext';

const Dashboard = () => {
  const { user, userManager, log, login, logout, testApi } =
    useContext(AuthContext);

  useEffect(() => {
    if (userManager) {
      document.getElementById('login')!.addEventListener('click', login, false);
      document.getElementById('api')!.addEventListener('click', testApi, false);
      document
        .getElementById('logout')!
        .addEventListener('click', logout, false);

      userManager!.events.addUserSignedOut(() => {
        console.log('User signed out of IdentityServer');
      });

      userManager!.getUser().then((user) => {
        if (user) {
          console.log('User logged in', user.profile);
        } else {
          console.log('User not logged in');
        }
      });
    }
  }, [userManager, log, login, logout, testApi]);

  return (
    <>
      <h2>Dashboard</h2>

      <button type='button' id='login'>
        Login
      </button>
      <button type='button' id='api'>
        Call API
      </button>
      <button type='button' id='logout'>
        Logout
      </button>

      <pre id='results' />
    </>
  );
};

export default Dashboard;
