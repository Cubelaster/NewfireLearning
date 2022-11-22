import { Button, message } from 'antd';
import { AxiosError } from 'axios';
import React, { useCallback, useContext, useState } from 'react';
import { useLocation, useNavigate } from 'react-router-dom';
import Spinner from '../components/layouts/spinner/spinner';
import AuthContext from '../contexts/authContext';
import { WeatherForecast } from '../core/models/WeatherForecast';
import weatherForecastService from '../core/services/weatherForecastService';

const ApiTest = () => {
  const navigate = useNavigate();
  const location = useLocation();
  const [isLoading, setIsLoading] = useState<boolean>(false);
  const [weatherForecast, setWeatherForecast] = useState<
    Array<WeatherForecast> | undefined
  >(undefined);
  const { user, userManager } = useContext(AuthContext);
  const [messageApi, contextHolder] = message.useMessage();

  const getWeatherForecast = useCallback(() => {
    setIsLoading(true);
    weatherForecastService.setToken(user!.access_token);
    weatherForecastService
      .get<Array<WeatherForecast>>()
      .then((response: Array<WeatherForecast>) => {
        setWeatherForecast(response);
      })
      .catch((error: AxiosError) => {
        messageApi.open({
          type: 'error',
          content: 'Error trying to get weather forecast',
        });
      })
      .finally(() => {
        setIsLoading(false);
      });
  }, [userManager, user]);

  return (
    <>
      {contextHolder}
      {isLoading ? (
        <Spinner tip='Loading weather report...' />
      ) : (
        <Button onClick={getWeatherForecast}>Load Weather Report</Button>
      )}
    </>
  );
};

export default ApiTest;
