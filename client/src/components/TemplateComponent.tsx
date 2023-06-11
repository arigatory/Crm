import { HTMLAttributes } from "react";

type TemplateComponentProps = HTMLAttributes<HTMLDivElement> & {
  children: React.ReactNode;
};

export const TemplateComponent = ({ children }: TemplateComponentProps) => {

  return (
    <div>
      {children}
    </div>
  );
};
