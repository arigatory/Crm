import { RouteObject, createBrowserRouter } from 'react-router-dom';
import App from '../App';
import HomePage from '../pages/HomePage';
import DesktopPage from '../pages/DesktopPage';
import ProjectsPage from '../pages/ProjectsPage';
import ServicesPage from '../pages/ServicesPage';
import BlogPage from '../pages/BlogPage';
import ContactsPage from '../pages/ContactsPage';
import { LoginPage } from '../pages/LoginPage';

export const routes: RouteObject[] = [
  {
    path: '/',
    element: <App />,
    children: [
      {path: '', element: <HomePage />},
      {path: 'desktop', element: <DesktopPage />},
      {path: 'projects', element: <ProjectsPage />},
      {path: 'services', element: <ServicesPage />},
      {path: 'blog', element: <BlogPage />},
      {path: 'contacts', element: <ContactsPage />},
      {path: 'login', element: <LoginPage />},
    ]
  },
];

export const router = createBrowserRouter(routes);
