import { DesktopOutlined, LockOutlined } from '@ant-design/icons';
import { Menu } from 'antd';
import { ItemType } from 'antd/lib/menu/hooks/useItems';
import React from 'react';
import { Link, useLocation } from 'react-router-dom';
import logo from '../../logo.svg';

export const SidebarMenu: React.FC = () => {
  const location = useLocation();

  const menuItems: Array<ItemType> = [
    {
      key: 'dashboard',
      icon: (
        <img src={logo} style={{ height: '16px', width: '16px' }} alt='logo' />
      ),
      label: <Link to='/dashboard'>The best app ever</Link>,
    },
    {
      key: 'private',
      icon: <LockOutlined />,
      label: <Link to='/private'>Private</Link>,
    },
    {
      key: 'about',
      icon: <DesktopOutlined />,
      label: <Link to='/about'>About</Link>,
    },
  ];

  return (
    <Menu
      items={menuItems}
      theme='dark'
      selectedKeys={[location.pathname.split('/')[1] ?? 'dashboard']}
      defaultSelectedKeys={['dashboard']}
      mode='inline'
    />
  );
};
