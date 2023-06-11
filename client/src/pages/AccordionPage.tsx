import { Accordion } from '../components/Accordion';

function AccordionPage() {
  const items = [
    {
      id: '1',
      label: 'Item 1',
      content: 'Content 1',
    },
    {
      id: '2',
      label: 'Item 2',
      content: 'Content 2',
    },
    {
      id: '3',
      label: 'Item 3',
      content:
        'Lorem ipsum dolor sit amet consectetur adipisicing elit. Veritatis dolor, magni et corrupti reprehenderit dolorem incidunt repellendus modi eveniet sequi laudantium harum sint voluptate laboriosam? Quos minima omnis ea, saepe quidem nisi hic dolore doloribus at illo commodi voluptatibus veritatis esse delectus, in itaque obcaecati et repellendus numquam adipisci rerum natus maxime distinctio! Itaque laudantium cumque beatae, dolores, facere quaerat ut dolor, quam reprehenderit eaque quo dolorem cupiditate qui ipsam adipisci eius blanditiis distinctio repudiandae rerum amet similique sapiente quos. Quibusdam, quas laudantium? Modi et voluptatibus, nesciunt accusamus temporibus tempore facere laborum expedita quidem in consectetur excepturi. Temporibus, inventore deserunt.',
    },
  ];
  return (
    <div>
      <Accordion items={items} />
    </div>
  );
}

export default AccordionPage;
