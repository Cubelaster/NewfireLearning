import { User, UserManager } from 'oidc-client';
import React, {
  PropsWithChildren,
  useCallback,
  useEffect,
  useMemo,
  useState,
} from 'react';
import { useLocalStorage } from 'usehooks-ts';
import AppConfigContext from './appConfigContext';

export interface AuthContextProps {
  user?: User;
  setUser: (user: User) => void;
  originalRoute?: string;
  userManager?: UserManager;
  login: () => void;
  logout: () => void;
  log: (...params: any[]) => void;
}

const AuthContext = React.createContext<AuthContextProps>(
  {} as AuthContextProps
);

export const AuthContextProvider = (props: PropsWithChildren) => {
  const appConfigContext = React.useContext(AppConfigContext);

  const [user, setUser] = useState<User | undefined>(undefined);
  const [originalRoute, setOriginalRoute] = useLocalStorage(
    'userManager_originalRoute',
    '/'
  );

  const userManager = useMemo(
    () => new UserManager(appConfigContext.oidcClientSettings),
    [appConfigContext]
  );

  const login = useCallback((): void => {
    userManager.signinRedirect();
  }, [userManager]);

  const logout = useCallback((): void => {
    userManager.signoutRedirect();
  }, [userManager, user]);

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
        originalRoute,
        userManager,
        log,
        login,
        logout,
      }}
    >
      {props.children}
    </AuthContext.Provider>
  );
};

export default AuthContext;
