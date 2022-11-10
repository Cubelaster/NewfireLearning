import React, { PropsWithChildren } from 'react';
import { Navigate, Outlet, useLocation } from 'react-router-dom';

// https://www.robinwieruch.de/react-router-private-routes/

export interface PrivateRouteProps {
  redirectTo: string;
  forceAllow: boolean;
}

const PrivateRoute = (
  props: PropsWithChildren<Partial<PrivateRouteProps>>
): JSX.Element => {
  const { redirectTo = '/401', forceAllow = false } = props;
  const location = useLocation();

  if (forceAllow) {
    return props.children ? <>(props.children)</> : <Outlet />;
  }

  return <Navigate to={redirectTo} state={{ from: location }} replace />;
};

export default PrivateRoute;
