import { Skeleton } from 'antd';
import React, {
  PropsWithChildren,
  useContext,
  useEffect,
  useState,
} from 'react';
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
  const { redirectTo = '/401', forceAllow = false } = props;
  const location = useLocation();
  const { userManager, user, setUser } = useContext(AuthContext);
  const [isLoading, setIsLoading] = useState<boolean>(true);
  const [isError, setIsError] = useState<boolean>(false);

  useEffect(() => {
    checkUser();
  }, []);

  const checkUser = async (): Promise<void> => {
    setIsLoading(true);
    if (user && user.id_token) {
      setIsError(false);
    } else {
      await userManager
        ?.getUser()
        .then((user) => {
          if (user) {
            setUser(user);
            setIsError(false);
          } else {
            setIsError(true);
          }
        })
        .catch((e) => {
          setIsError(true);
        });
    }
    setIsLoading(false);
  };

  return isLoading ? (
    <Skeleton />
  ) : isError ? (
    <Navigate to={redirectTo} state={{ from: location }} replace />
  ) : (
    <Outlet />
  );
};

export default PrivateRoute;
