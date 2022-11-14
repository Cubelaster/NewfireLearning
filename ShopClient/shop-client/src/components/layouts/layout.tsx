import { DesktopOutlined, LockOutlined } from '@ant-design/icons';
import { Layout, Menu } from 'antd';
import React, { useState } from 'react';
import { Link, Outlet, useLocation } from 'react-router-dom';
import logo from '../../logo.svg';
const { Header, Content, Footer, Sider } = Layout;

const AppLayout: React.FC = () => {
  const [collapsed, setCollapsed] = useState(false);
  const location = useLocation();

  return (
    <Layout style={{ minHeight: '100vh' }}>
      <Sider
        collapsible
        collapsed={collapsed}
        onCollapse={(value) => setCollapsed(value)}
      >
        <Menu
          theme='dark'
          selectedKeys={[location.pathname.split('/')[1] ?? 'dashboard']}
          defaultSelectedKeys={['dashboard']}
          mode='inline'
        >
          <Menu.Item
            key={'dashboard'}
            icon={
              <img
                src={logo}
                style={{ height: '16px', width: '16px' }}
                alt='logo'
              />
            }
          >
            <Link to='/dashboard'>The best app ever</Link>
          </Menu.Item>
          <Menu.Item key={'private'} icon={<LockOutlined />}>
            <Link to='/private'>Private</Link>
          </Menu.Item>
          <Menu.Item key={'about'} icon={<DesktopOutlined />}>
            <Link to='/about'>About</Link>
          </Menu.Item>
        </Menu>
      </Sider>
      <Layout>
        <Header />
        <Content style={{ margin: '10px' }}>
          <Outlet />
        </Content>
        <Footer style={{ textAlign: 'center' }}>
          Ant Design ©2022 Created by Ant UED
        </Footer>
      </Layout>
    </Layout>
  );
};

export default AppLayout;
