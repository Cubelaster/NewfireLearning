import { UserManager } from 'oidc-client';
import React, { useEffect } from 'react';
import { useNavigate } from 'react-router-dom';

const Callback = () => {
  const navigate = useNavigate();
  useEffect(() => {
    new UserManager({ response_mode: 'query' })
      .signinRedirectCallback()
      .then(() => {
        navigate('/');
      })
      .catch((e) => {
        console.error(e);
      });
  }, []);
  return <h2>Callback</h2>;
};

export default Callback;
