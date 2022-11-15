import { Layout } from 'antd';
import React from 'react';
import {
  mainFillerElementStyle,
  mainFlexStyle,
} from '../../core/utilities/styleUtilities';
import { UserMenu } from '../user/userMenu';

const { Header } = Layout;

export const AppHeader: React.FC = () => {
  const headerStyle: React.CSSProperties = {
    ...mainFlexStyle,
    padding: '0 10px',
  };

  const userDisplayStyle: React.CSSProperties = {
    ...mainFlexStyle,
    maxWidth: '100px',
    justifyContent: 'center',
  };

  return (
    <Header style={headerStyle}>
      <div style={mainFillerElementStyle}></div>
      <div style={userDisplayStyle}>
        <UserMenu />
      </div>
    </Header>
  );
};
