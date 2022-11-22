import { HttpService } from './httpService/HttpService';

const BaseRoute = 'WeatherForecast';

class WeatherForecastService extends HttpService {}

const weatherForecastService = new WeatherForecastService(
  'https://localhost:5002',
  BaseRoute
);

export default weatherForecastService;
