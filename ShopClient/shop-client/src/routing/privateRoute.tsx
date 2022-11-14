import React, { PropsWithChildren, useContext } from 'react';
import { Navigate, Outlet, useLocation } from 'react-router-dom';
import AuthContext from '../contexts/authContext';

// https://www.robinwieruch.de/react-router-private-routes/

export interface PrivateRouteProps {
  redirectTo: string;
  forceAllow: boolean;
}

const PrivateRoute = (
  props: PropsWithChildren<Partial<PrivateRouteProps>>
): JSX.Element => {
  const { redirectTo = '/403', forceAllow = false } = props;
  const location = useLocation();
  const { user } = useContext(AuthContext);

  if (forceAllow || user) {
    return props.children ? <>(props.children)</> : <Outlet />;
  }
  return <Navigate to={redirectTo} state={{ from: location }} replace />;
};

export default PrivateRoute;
