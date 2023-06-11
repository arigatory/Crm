import { Outlet } from 'react-router-dom';
import { Header } from './components/Header';

function App() {
  return (
    <>
      <Header />
      <div className=" bg-gray-100 p-4">
        <Outlet />
      </div>
    </>
  );
}

export default App;
