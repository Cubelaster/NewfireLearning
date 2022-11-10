import React, { useContext, useEffect } from 'react';
import { useNavigate } from 'react-router-dom';
import Spinner from '../components/layouts/spinner/spinner';
import AuthContext from '../contexts/authContext';

const Callback = () => {
  const navigate = useNavigate();
  const { setUser, userManager } = useContext(AuthContext);

  useEffect(() => {
    if (userManager) {
      userManager
        .signinRedirectCallback()
        .then((user) => {
          setUser(user);
          navigate('/');
        })
        .catch((e) => {
          console.error(e);
        });
    }
  }, [userManager]);

  return <Spinner tip='Logging you in...' />;
};

export default Callback;
