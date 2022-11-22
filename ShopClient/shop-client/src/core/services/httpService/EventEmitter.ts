export interface IEventEmitter {
  on(name: string, listener: Function): void;
  removeListener(name: string, listener: Function): void;
  emit(name: string, data?: any): void;
}

export class EventEmitter implements IEventEmitter {
  private readonly events: Record<string, Function[]>;

  public constructor() {
    this.events = {};
  }

  public on(name: string, listener: Function) {
    if (!this.events[name]) {
      this.events[name] = [];
    }

    this.events[name].push(listener);
  }

  public removeListener(name: string, listenerToRemove: Function) {
    if (!this.events[name]) {
      throw new Error(
        `Can't remove a listener. Event "${name}" doesn't exits.`
      );
    }

    const filterListeners = (listener: Function) =>
      listener !== listenerToRemove;

    this.events[name] = this.events[name].filter(filterListeners);
  }

  public emit(name: string, data: any) {
    if (!this.events[name]) {
      throw new Error(`Can't emit an event. Event "${name}" doesn't exits.`);
    }

    const fireCallbacks = (callback: Function) => {
      callback(data);
    };

    this.events[name].forEach(fireCallbacks);
  }
}
