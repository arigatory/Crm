import { HeaderItem } from './HeaderItem';
import { MdOutlineDashboardCustomize } from 'react-icons/md';
import { HiOutlinePuzzle } from 'react-icons/hi';
import { AiOutlineStar } from 'react-icons/ai';
import { NavLink } from 'react-router-dom';
import { Fragment, useState } from 'react';
import { Dialog, Disclosure, Popover, Transition } from '@headlessui/react';
import {
  ArrowPathIcon,
  Bars3Icon,
  ChartPieIcon,
  CursorArrowRaysIcon,
  FingerPrintIcon,
  SquaresPlusIcon,
  XMarkIcon,
} from '@heroicons/react/24/outline';
import {
  ChevronDownIcon,
  PhoneIcon,
  PlayCircleIcon,
} from '@heroicons/react/20/solid';

const products = [
  {
    name: 'Analytics',
    description: 'Get a better understanding of your traffic',
    href: '#',
    icon: ChartPieIcon,
  },
  {
    name: 'Engagement',
    description: 'Speak directly to your customers',
    href: '#',
    icon: CursorArrowRaysIcon,
  },
  {
    name: 'Security',
    description: 'Your customers’ data will be safe and secure',
    href: '#',
    icon: FingerPrintIcon,
  },
  {
    name: 'Integrations',
    description: 'Connect with third-party tools',
    href: '#',
    icon: SquaresPlusIcon,
  },
  {
    name: 'Automations',
    description: 'Build strategic funnels that will convert',
    href: '#',
    icon: ArrowPathIcon,
  },
];
const callsToAction = [
  { name: 'Watch demo', href: '#', icon: PlayCircleIcon },
  { name: 'Contact sales', href: '#', icon: PhoneIcon },
];

function classNames(...classes: string[]) {
  return classes.filter(Boolean).join(' ');
}

export const Header = () => {
  const [mobileMenuOpen, setMobileMenuOpen] = useState(false);

  return (
    <header className="bg-white">
      <nav
        className="mx-auto flex max-w-7xl items-center justify-between p-6 lg:px-8"
        aria-label="Global"
      >
        <div className="flex lg:flex-1">
          <a href="#" className="-m-1.5 p-1.5">
            <span className="sr-only">Your Company</span>
            <img
              className="h-8 w-auto"
              src="https://tailwindui.com/img/logos/mark.svg?color=indigo&shade=600"
              alt=""
            />
          </a>
        </div>
        <div className="flex lg:hidden">
          <button
            type="button"
            className="-m-2.5 inline-flex items-center justify-center rounded-md p-2.5 text-gray-700"
            onClick={() => setMobileMenuOpen(true)}
          >
            <span className="sr-only">Open main menu</span>
            <Bars3Icon className="h-6 w-6" aria-hidden="true" />
          </button>
        </div>
        <Popover.Group className="hidden lg:flex lg:gap-x-12">
          <NavLink
            to="desktop"
            className="text-sm font-semibold leading-6 text-gray-900"
          >
            Рабочий стол
          </NavLink>
          <NavLink
            to="/"
            className="text-sm font-semibold leading-6 text-gray-900"
          >
            Главная
          </NavLink>
          <NavLink
            to="/projects"
            className="text-sm font-semibold leading-6 text-gray-900"
          >
            Проекты
          </NavLink>
          <NavLink
            to="/blog"
            className="text-sm font-semibold leading-6 text-gray-900"
          >
            Блог
          </NavLink>
          <NavLink
            to="/services"
            className="text-sm font-semibold leading-6 text-gray-900"
          >
            Услуги
          </NavLink>
          <NavLink
            to="/contacts"
            className="text-sm font-semibold leading-6 text-gray-900"
          >
            Контакты
          </NavLink>
        </Popover.Group>

        <div className="hidden lg:flex lg:flex-1 lg:justify-end">
          <NavLink to="/login" className="text-sm font-semibold leading-6 text-gray-900">
            Войти <span aria-hidden="true">&rarr;</span>
          </NavLink>
        </div>
      </nav>
    </header>

    // <div className="flex right-0 left-0 top-0 pb-5 pt-3 bg-white">
    //   <NavLink to="/desktop">
    //     <HeaderItem text="Рабочий стол" icon={HiOutlinePuzzle} />
    //   </NavLink>

    //   <NavLink to="/">
    //     <HeaderItem text="Главная" icon={MdOutlineDashboardCustomize} active />
    //   </NavLink>

    //   <NavLink to="/projects">
    //     <HeaderItem text="Проекты" icon={HiOutlinePuzzle} />
    //   </NavLink>

    //   <NavLink to="/blog">
    //     <HeaderItem text="Блог" icon={HiOutlinePuzzle} />
    //   </NavLink>

    //   <NavLink to="/services">
    //     <HeaderItem text="Услуги" icon={AiOutlineStar} />
    //   </NavLink>

    //   <NavLink to="/contacts">
    //     <HeaderItem text="Контакты" icon={HiOutlinePuzzle} />
    //   </NavLink>
    // </div>
  );
};
