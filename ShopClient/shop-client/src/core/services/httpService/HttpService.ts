import axios, { AxiosError, AxiosInstance } from 'axios';

export interface IHttpService {
  instance: AxiosInstance;
}

export class HttpService implements IHttpService {
  public readonly instance: AxiosInstance;
  private token?: string;

  constructor(baseURL: string, serviceUrl: string = '') {
    this.instance = axios.create({ baseURL: baseURL + '/' + serviceUrl });
  }

  setToken = (newToken: string): void => {
    this.token = newToken;
  };

  handleError = (err: AxiosError): any => {
    const { message, response } = err;

    if (message) {
      // notificationService.error(message);
      return message;
    }
    if (response) {
      const { status, statusText, data } = response;
      let customErrorMsg = '';
      if (status) {
        customErrorMsg = customErrorMsg.concat(status.toString(), '-');
      }
      if (statusText) {
        customErrorMsg = customErrorMsg.concat(statusText.toString(), '-');
      }
      // if (data && data.error) {
      //   customErrorMsg = customErrorMsg.concat(data.error.toString(), ' ');
      // }
      // notificationService.error(customErrorMsg);
      return response;
    }
    return err;
  };

  get = async <T>(url: string = ''): Promise<T> => {
    const res = await this.instance
      .get<T>(url, {
        headers: {
          Authorization: `Bearer ${this.token}`,
          // 'Accept-Language': targetLocale(),
        },
      })
      .catch(this.handleError);
    return res.data;
  };
}
