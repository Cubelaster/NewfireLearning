import React, { useContext, createContext, useState } from 'react';
import {
  BrowserRouter as Router,
  Route,
  Link,
  useLocation,
  redirect,
  Navigate,
} from 'react-router-dom';

const PrivateRoute = ({
  children,
  redirectTo,
}: { children?: JSX.Element } & { redirectTo: string }) => {
  //   let auth = useAuth();
  const location = useLocation();
  return <Navigate to={redirectTo} state={{ from: location }} replace />;
  //   return <div>Private</div>;
  //   return (
  //     <Route
  //       {...rest}
  //       render={({ location }) =>
  //         auth.user ? (
  //           children
  //         ) : (
  //           <Redirect
  //             to={{
  //               pathname: '/login',
  //               state: { from: location },
  //             }}
  //           />
  //         )
  //       }
  //     />
  //   );
};

export default PrivateRoute;
