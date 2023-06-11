import { HeaderItem } from './HeaderItem';
import { MdOutlineDashboardCustomize } from 'react-icons/md';
import { HiOutlinePuzzle } from 'react-icons/hi';
import { AiOutlineStar } from 'react-icons/ai';
import { NavLink } from 'react-router-dom';

export const Header = () => {
  return (
    <div className="flex fixed right-0 left-0 top-0 pb-5 pt-3 bg-white">
      <NavLink to="/desktop">
        <HeaderItem text="Рабочий стол" icon={HiOutlinePuzzle} />
      </NavLink>

      <NavLink to="/">
        <HeaderItem text="Главная" icon={MdOutlineDashboardCustomize} active />
      </NavLink>

      <NavLink to="/projects">
        <HeaderItem text="Проекты" icon={HiOutlinePuzzle} />
      </NavLink>

      <NavLink to="/blog">
        <HeaderItem text="Блог" icon={HiOutlinePuzzle} />
      </NavLink>

      <NavLink to="/services">
        <HeaderItem text="Услуги" icon={AiOutlineStar} />
      </NavLink>

      <NavLink to="/contacts">
        <HeaderItem text="Контакты" icon={HiOutlinePuzzle} />
      </NavLink>
    </div>
  );
};
