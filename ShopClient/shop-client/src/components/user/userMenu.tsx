import { LoginOutlined, LogoutOutlined, UserOutlined } from '@ant-design/icons';
import { Avatar, Button, Dropdown, Image } from 'antd';
import { ItemType } from 'antd/lib/menu/hooks/useItems';
import React, { useCallback, useContext, useMemo } from 'react';
import { useNavigate } from 'react-router-dom';
import AuthContext from '../../contexts/authContext';
import { getInitials } from '../../core/utilities/utilities';
import PrivateRoute from '../../routing/privateRoute';

export const UserMenu = () => {
  const { user, logout, login } = useContext(AuthContext);
  const navigate = useNavigate();

  const getFullName = (): string => {
    return `${user?.profile?.name ?? ''} ${user?.profile?.family_name ?? ''}`;
  };

  const getUserInitials = useCallback(() => {
    const fullName = getFullName();

    if (fullName.length < 1) {
      return 'User';
    }

    return getInitials(fullName);
  }, [user, getFullName]);

  const menuItems: Array<ItemType> = useMemo(() => {
    return [
      {
        key: 'profile',
        icon: <UserOutlined />,
        label: (
          <Button type='text' onClick={() => navigate('/profile')}>
            {getUserInitials()}
          </Button>
        ),
      },
      {
        key: 'logout',
        icon: <LogoutOutlined />,
        label: (
          <Button type='text' onClick={logout}>
            Logout
          </Button>
        ),
      },
    ];
  }, [user, getUserInitials, logout]);

  const userDropdown = useMemo(() => {
    return (
      <PrivateRoute
        forbiddenComponent={
          <Button onClick={login} icon={<LoginOutlined />}>
            Login
          </Button>
        }
      >
        <Dropdown
          menu={{
            items: menuItems,
          }}
        >
          <Avatar>
            {user?.profile.picture ? (
              <Image src={user?.profile?.picture} />
            ) : (
              getUserInitials()
            )}
          </Avatar>
        </Dropdown>
      </PrivateRoute>
    );
  }, [user, login, getUserInitials]);

  return userDropdown;
};
