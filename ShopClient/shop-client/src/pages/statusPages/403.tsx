import { Button, Result } from 'antd';
import React from 'react';
import { Link } from 'react-router-dom';

const FourOhThree: React.FC = () => (
  <Result
    status='403'
    title='403'
    subTitle='Well, seems you lack permissions to do so...'
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
        <span>You should try something else</span>
        <Button type='primary' key='home'>
          <Link to='/dashboard'>Home</Link>
        </Button>
      </div>
    }
  />
);

export default FourOhThree;
