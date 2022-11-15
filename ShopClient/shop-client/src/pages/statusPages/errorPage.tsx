import { Button, Result } from 'antd';
import React from 'react';
import { Link } from 'react-router-dom';

export const ErrorPage: React.FC<Partial<Error> | undefined> = (
  props = undefined
) => {
  console.log(props);

  return (
    <Result
      status='500'
      title='500'
      subTitle='Sorry, something went wrong.'
      extra={
        <Button type='primary' key='home'>
          <Link to='/dashboard'>Home</Link>
        </Button>
      }
    />
  );
};
