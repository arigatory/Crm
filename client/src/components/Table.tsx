export type TableConfigType<T> = {
  label: string;
  render: (row: T) => React.ReactNode | string | number;
}[];

type TableProps<T> = {
  data: T[];
  config: TableConfigType<T>;
  keyFn: (x: T) => string;
};

export const Table = <T,>({ data, config, keyFn }: TableProps<T>) => {
  const renderedHeaders = config.map((column) => {
    return <th key={column.label}>{column.label}</th>;
  });

  const renderedRows = data.map((rowData) => {
    const renderedCells = config.map((column) => {
      return (
        <td className="p-2" key={column.label}>
          {column.render(rowData)}
        </td>
      );
    });
    return (
      <tr className="border-b" key={keyFn(rowData)}>
        {renderedCells}
      </tr>
    );
  });
  return (
    <table className="table-auto border-spacing-2">
      <thead>
        <tr className="border-b-2">{renderedHeaders}</tr>
      </thead>
      <tbody>{renderedRows}</tbody>
    </table>
  );
};
