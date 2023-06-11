import classNames from 'classnames-ts';
import { HTMLAttributes } from 'react';
import { IconType } from 'react-icons/lib/esm/iconBase';


type IconInfoProps = HTMLAttributes<HTMLDivElement> & {
  text: string;
  icon: IconType;
  className?: string;
};

export const IconInfo = ({ icon, text, className, ...rest }: IconInfoProps) => {
  const finalClassNames = classNames(
    'p-1 w-full flex gap-2 items-center align-middle center-content group-hover:text-white',
    className
  );
  return (
    <div {...rest} className={finalClassNames}>
      {icon({ className: 'text-rbgblue text-xl group-hover:text-white' })}
      <span className='text-small text-gray-600 font-semibold group-hover:text-white'>{text}</span>
    </div>
  );
};
