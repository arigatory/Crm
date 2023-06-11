import classNames from 'classnames-ts';
import { HTMLAttributes } from 'react';

type PanelProps = HTMLAttributes<HTMLDivElement> & {
  children: React.ReactNode;
  className?: string;
};

export const Panel = ({ children, className, ...rest }: PanelProps) => {
  const finalClassNames = classNames(
    'border rounded p-3 shadow bg-white w-full',
    className
  );
  return (
    <div {...rest} className={finalClassNames}>
      {children}
    </div>
  );
};
