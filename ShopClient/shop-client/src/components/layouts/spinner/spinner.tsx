import { Spin, SpinProps } from 'antd';
import React from 'react';
import './spinner.scss';

const Spinner = (props: SpinProps) => {
  return <Spin className='center-spin' {...props} />;
};

export default Spinner;
