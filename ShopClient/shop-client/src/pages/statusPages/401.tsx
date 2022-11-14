import { Button, Result } from 'antd';
import React, { useContext, useEffect } from 'react';
import { useLocation } from 'react-router-dom';
import { useLocalStorage } from 'usehooks-ts';

import AuthContext from '../../contexts/authContext';

export const FourOhOne: React.FC = () => {
  const { login } = useContext(AuthContext);
  const [originalRoute, setOriginalRoute] = useLocalStorage(
    'userManager_originalRoute',
    '/'
  );
  const location = useLocation();

  useEffect(() => {
    setOriginalRoute((location.state.from as Location).pathname);
  });

  return (
    <Result
      status='warning'
      title='401'
      subTitle='You should try logging in...'
      extra={
        <div
          style={{
            display: 'flex',
            justifyContent: 'center',
            alignItems: 'center',
            flexDirection: 'column',
            gap: '10px',
          }}
        >
          <Button type='primary' key='home' onClick={login}>
            Login
          </Button>
        </div>
      }
    />
  );
};
