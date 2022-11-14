import React, { useContext, useEffect } from 'react';
import { Navigate, useNavigate } from 'react-router-dom';
import Spinner from '../components/layouts/spinner/spinner';
import AuthContext from '../contexts/authContext';

const Callback = () => {
  const navigate = useNavigate();
  const { setUser, userManager, originalRoute } = useContext(AuthContext);

  useEffect(() => {
    if (userManager) {
      userManager
        .signinRedirectCallback()
        .then((user) => {
          setUser(user);

          if (originalRoute) {
            navigate(originalRoute, { replace: true });
          }
        })
        .catch((e) => (
          <Navigate to={'/error'} state={{ from: location }} {...e} replace />
        ));
    }
  }, [userManager]);

  return <Spinner tip='Logging you in...' />;
};

export default Callback;
