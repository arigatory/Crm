import { Table, TableConfigType } from '../components/Table';
import { Fruit } from '../types/Fruit';

function DesktopPage() {
  const data: Fruit[] = [
    {
      name: 'Orange',
      color: 'bg-orange-500',
      score: 5,
    },
    {
      name: 'Apple',
      color: 'bg-red-500',
      score: 3,
    },
    {
      name: 'Banana',
      color: 'bg-yellow-500',
      score: 1,
    },
    {
      name: 'Lime',
      color: 'bg-green-500',
      score: 4,
    },
  ];

  const config: TableConfigType<Fruit> = [
    {
      label: 'Name',
      render: (fruit) => fruit.name,
    },
    {
      label: 'Color',
      render: (fruit) => <div className={`p-3 m-2 ${fruit.color}`}></div>,
    },
    {
      label: 'Score',
      render: (fruit) => fruit.score.toString(),
    },
  ];

  const keyFn = (fruit: Fruit) => {
    return fruit.name
  };

  return (
    <div>
      <Table data={data} config={config} keyFn={keyFn} />
    </div>
  );
}

export default DesktopPage;
