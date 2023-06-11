import classNames from 'classnames-ts';
import { HTMLAttributes } from 'react';
import { IconType } from 'react-icons/lib/esm/iconBase';

type HeaderItemProps = HTMLAttributes<HTMLDivElement> & {
  text: string;
  icon: IconType;
  className?: string;
  active?: boolean;
};

export const HeaderItem = ({
  text,
  icon,
  className,
  active,
}: HeaderItemProps) => {
  const finalClassNames = classNames(
    'p-1 w-full flex flex-row gap-2 items-center align-middle center-content cursor-pointer group',
    className
  );
  const iconClassNames = classNames('text-gray-400 text-middle group-hover:text-blue-600', {
    'text-blue-700 font-bold': active,
    'text-blue-400': !active,
  });
  const textClasses = classNames('text-small font-semibold group-hover:text-blue-600', {
    'text-blue-700 font-bold': active,
    'text-blue-400': !active,
  });
  return (
    <div className={finalClassNames}>
      {icon({ className: iconClassNames })}
      <span className={textClasses}>{text}</span>
    </div>
  );
};
