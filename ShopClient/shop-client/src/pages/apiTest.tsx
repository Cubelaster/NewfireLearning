import axios from 'axios';
import { User } from 'oidc-client';
import React, { useContext, useEffect } from 'react';
import { useLocation, useNavigate } from 'react-router-dom';
import AuthContext from '../contexts/authContext';

const ApiTest = () => {
  const navigate = useNavigate();
  const location = useLocation();
  const { user, userManager } = useContext(AuthContext);

  const loadData = async (user: User): Promise<void> => {
    var result = await axios({
      baseURL: 'https://localhost:5002',
      url: 'WeatherForecast',
      method: 'GET',
      headers: {
        Authorization: `Bearer ${user!.access_token}`,
      },
    });

    console.log(result);
  };

  useEffect(() => {
    if (userManager && user) {
      loadData(user);
    }
  }, [userManager, user]);

  return <div>Api Test</div>;
};

export default ApiTest;
