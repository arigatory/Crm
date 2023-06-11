import { useEffect, useState, useRef } from 'react';
import { GoChevronDown } from 'react-icons/go';
import { Panel } from './Panel';

export type Option = {
  label: string;
  value: string;
};

type DropdownProps = {
  value: Option | null;
  onChange: (option: Option) => void;
  options: {
    label: string;
    value: string;
  }[];
};

export const Dropdown = ({
  options,
  value: value,
  onChange: onChange,
}: DropdownProps) => {
  const [isOpen, setIsOpen] = useState(false);

  const divEl = useRef<HTMLDivElement>(null);

  useEffect(() => {
    const handler = (event: MouseEvent) => {
      if (!divEl.current?.contains(event.target as Node)) {
        setIsOpen(false);
      }
    };
    document.addEventListener('click', handler, true);

    return () => {
      document.removeEventListener('click', handler);
    };
  }, []);

  const handleClick = () => {
    setIsOpen((current) => !current);
  };

  const handleOptionClick = (option: { label: string; value: string }) => {
    setIsOpen(false);
    onChange(option);
  };

  const renderedOptions = options.map((option) => {
    return (
      <div
        className="hover:bg-sky-100 rounded cursor-pointer p-1"
        onClick={() => handleOptionClick(option)}
        key={option.value}
      >
        <div>{option.label}</div>
      </div>
    );
  });

  return (
    <div className="w-48 relative" ref={divEl}>
      <Panel
        className="flex justify-between items-center cursor-pointer"
        onClick={handleClick}
      >
        {value?.label || 'Select...'}
        {<GoChevronDown className="text-lg" />}
      </Panel>
      {isOpen && <Panel className=" top-full">{renderedOptions}</Panel>}
    </div>
  );
};
