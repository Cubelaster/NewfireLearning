import { OidcClientSettings, UserManager } from 'oidc-client';
import React, { useCallback, useEffect, useMemo } from 'react';

const Dashboard = () => {
  const config = useMemo(
    () => ({
      authority: 'https://localhost:5001',
      client_id: 'react',
      client_secret: 'secret',
      redirect_uri: 'https://localhost:5005/callback',
      response_type: 'code',
      scope: 'openid profile article.read article.write',
      post_logout_redirect_uri: 'https://localhost:5005/',
    }),
    []
  );
  // const config = useMemo(() => JSON.parse(process.env.REACT_APP_OIDCCLIENTSETTINGS!) as OidcClientSettings, []);
  const mgr = useMemo(() => new UserManager(config), [config]);

  const log = (...params: any[]): void => {
    document.getElementById('results')!.innerText = '';

    Array.prototype.forEach.call(params, (msg) => {
      if (typeof msg !== 'undefined') {
        let newMsg = '';
        if (msg instanceof Error) {
          newMsg = `Error: ${msg.message}`;
        } else if (typeof msg !== 'string') {
          newMsg = JSON.stringify(msg, null, 2);
        }
        document.getElementById('results')!.innerText += `${newMsg} \r\n`;
      }
    });
  };

  const login = useCallback((): void => {
    mgr.signinRedirect();
  }, [mgr]);

  const api = useCallback((): void => {
    mgr.getUser().then((user) => {
      const url = 'https://localhost:5002/WeatherForecast';

      const xhr = new XMLHttpRequest();
      xhr.open('GET', url);
      xhr.onload = () => {
        log(xhr.status, JSON.parse(xhr.responseText));
      };
      xhr.setRequestHeader('Authorization', `Bearer ${user!.access_token}`);
      xhr.send();
    });
  }, [mgr]);

  useEffect(() => {}, []);

  const logout = useCallback((): void => {
    mgr.signoutRedirect();
  }, [mgr]);

  useEffect(() => {
    document.getElementById('login')!.addEventListener('click', login, false);
    document.getElementById('api')!.addEventListener('click', api, false);
    document.getElementById('logout')!.addEventListener('click', logout, false);

    mgr!.events.addUserSignedOut(() => {
      log('User signed out of IdentityServer');
    });

    mgr!.getUser().then((user) => {
      if (user) {
        log('User logged in', user.profile);
      } else {
        log('User not logged in');
      }
    });
  }, [login, logout, api, mgr]);

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
