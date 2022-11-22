import axios, { AxiosInstance, AxiosRequestConfig, AxiosResponse } from 'axios';
import { EventEmitter, IEventEmitter } from './EventEmitter';
import { IHttpService } from './HttpService';

export interface ICircuitBreaker {
  getStatus(): boolean;
}

export interface ICircuitBreakerOptions {
  timeout: number;
  errorHandler: (error: any) => boolean;
}

class CircuitBreaker implements ICircuitBreaker {
  private readonly http: IHttpService;
  private readonly timeout: number;
  private isOpen = false;
  private errorHandler: (error: any) => boolean;

  constructor(http: IHttpService, options: ICircuitBreakerOptions) {
    this.http = http;
    this.timeout = options.timeout;
    this.errorHandler = options.errorHandler;

    this.http.instance.interceptors.request.use(
      this.interceptRequest.bind(this)
    );
    this.http.instance.interceptors.response.use(
      (response: AxiosResponse) => response,
      this.interceptErrorResponse.bind(this)
    );
  }

  public getStatus() {
    return this.isOpen;
  }

  private interceptErrorResponse(error: any) {
    const shouldCircuitBreakerBeOpen = this.errorHandler(error);

    if (shouldCircuitBreakerBeOpen && !this.isOpen) {
      this.openCircuitBreaker();
    }

    return Promise.reject(error);
  }

  private openCircuitBreaker() {
    this.isOpen = true;

    setTimeout(() => {
      this.isOpen = false;
    }, this.timeout);
  }

  private interceptRequest(config: AxiosRequestConfig) {
    const CancelToken = axios.CancelToken;

    const cancelToken = new CancelToken((cancel) =>
      cancel('Circuit breaker is open')
    );

    return {
      ...config,
      ...(this.isOpen ? { cancelToken } : {}),
    };
  }
}

type CircuitBreakerEvents = 'OPEN' | 'CLOSE';
interface ICircuitBreakerWithEmitter extends ICircuitBreaker {
  on(event: CircuitBreakerEvents, listener: Function): void;
}

class CircuitBreakerWithEmitter implements ICircuitBreakerWithEmitter {
  private readonly http: IHttpService;
  private readonly timeout: number;
  private isOpen: boolean = false;
  private readonly errorHandler: (error: any) => boolean;
  private readonly eventEmitter: IEventEmitter;

  constructor(http: IHttpService, option: ICircuitBreakerOptions) {
    this.http = http;
    this.timeout = option.timeout;
    this.errorHandler = option.errorHandler;
    this.eventEmitter = new EventEmitter();

    this.http.instance.interceptors.request.use(
      this.interceptRequest.bind(this)
    );
    this.http.instance.interceptors.response.use(
      (response: AxiosResponse) => response,
      this.interceptErrorResponse.bind(this)
    );
  }

  public getStatus() {
    return this.isOpen;
  }

  public on(event: CircuitBreakerEvents, listener: Function) {
    this.eventEmitter.on(event, listener);
  }

  private interceptRequest(config: AxiosRequestConfig) {
    const CancelToken = axios.CancelToken;

    const cancelToken = new CancelToken((cancel) =>
      cancel('Circuit breaker is open')
    );

    return {
      ...config,
      ...(this.isOpen ? { cancelToken } : {}),
    };
  }

  private interceptErrorResponse(error: any) {
    const shouldCircuitBreakerBeOpen = this.errorHandler(error);

    if (shouldCircuitBreakerBeOpen && !this.isOpen) {
      this.openCircuitBreaker();
    }

    return Promise.reject(error);
  }

  private openCircuitBreaker() {
    this.isOpen = true;
    this.eventEmitter.emit('OPEN');

    setTimeout(() => {
      this.isOpen = false;
      this.eventEmitter.emit('CLOSE');
    }, this.timeout);
  }
}
