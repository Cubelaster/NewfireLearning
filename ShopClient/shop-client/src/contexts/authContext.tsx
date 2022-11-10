import { User, UserManager } from 'oidc-client';
import React, {
  PropsWithChildren,
  useCallback,
  useMemo,
  useState,
} from 'react';
import AppConfigContext from './appConfigContext';

export interface AuthContextProps {
  user?: User;
  setUser: (user: User) => void;
  userManager?: UserManager;
  login: () => void;
  logout: () => void;
  testApi: () => void;
  log: (...params: any[]) => void;
}

const AuthContext = React.createContext<AuthContextProps>(
  {} as AuthContextProps
);

export const AuthContextProvider = (props: PropsWithChildren) => {
  const [user, setUser] = useState<User | undefined>(undefined);

  const appConfigContext = React.useContext(AppConfigContext);

  const userManager = useMemo(
    () => new UserManager(appConfigContext.oidcClientSettings),
    [appConfigContext]
  );

  const login = useCallback((): void => {
    userManager.signinRedirect();
  }, [userManager]);

  const testApi = useCallback((): void => {
    userManager.getUser().then((response) => {
      const url = 'https://localhost:5002/WeatherForecast';

      const xhr = new XMLHttpRequest();
      xhr.open('GET', url);
      xhr.onload = () => {
        log(xhr.status, JSON.parse(xhr.responseText));
      };
      xhr.setRequestHeader('Authorization', `Bearer ${user!.access_token}`);
      xhr.send();
    });
  }, [userManager, user]);

  const logout = useCallback((): void => {
    userManager.signoutRedirect();
  }, [userManager]);

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

  return (
    <AuthContext.Provider
      value={{
        user,
        setUser,
        userManager,
        log,
        login,
        logout,
        testApi,
      }}
    >
      {props.children}
    </AuthContext.Provider>
  );
};

export default AuthContext;
