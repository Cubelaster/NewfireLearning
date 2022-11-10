import React, { PropsWithChildren } from 'react';
import { Navigate, Outlet, useLocation } from 'react-router-dom';

export interface PrivateRouteProps {
  redirectTo: string;
  forceAllow: boolean;
}

const PrivateRoute = (
  props: PropsWithChildren<Partial<PrivateRouteProps>>
): JSX.Element => {
  const { redirectTo = '/403', forceAllow = false } = props;
  const location = useLocation();

  if (forceAllow) {
    return props.children ? <>(props.children)</> : <Outlet />;
  }

  return <Navigate to={redirectTo} state={{ from: location }} replace />;
};

export default PrivateRoute;
