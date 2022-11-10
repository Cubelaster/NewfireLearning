import { OidcClientSettings } from 'oidc-client';
import React, { PropsWithChildren, useMemo } from 'react';

export interface AppConfig {
  oidcClientSettings: OidcClientSettings;
}

const AppConfigContext = React.createContext<AppConfig>({} as AppConfig);

export const AppConfigContextProvider = (props: PropsWithChildren) => {
  const oidcClientSettings = useMemo(
    () =>
      JSON.parse(
        process.env.REACT_APP_OIDCCLIENTSETTINGS!
      ) as OidcClientSettings,
    []
  );

  return (
    <AppConfigContext.Provider
      value={{
        oidcClientSettings,
      }}
    >
      {props.children}
    </AppConfigContext.Provider>
  );
};

export default AppConfigContext;
