import { useState } from 'react';
import { Dropdown } from '../components/Dropdown';

export type Option = { label: string; value: string };

function DropdownPage() {
  const [selection, setSelection] = useState<Option | null>(null);

  const handleSelect = (option: Option) => {
    setSelection(option);
  };

  const options = [
    { label: 'The Color Red', value: 'red' },
    { label: 'The Color Green', value: 'green' },
    { label: 'A Shade of Blue', value: 'blue' },
  ];

  return (
    <div className='flex'>
    <Dropdown options={options} value={selection} onChange={handleSelect} />
    <Dropdown options={options} value={selection} onChange={handleSelect} />
    <Dropdown options={options} value={selection} onChange={handleSelect} />


    </div>
  );
}

export default DropdownPage;
