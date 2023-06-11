import { GoBell, GoCloudDownload } from 'react-icons/go';
import Button from '../components/Button';

function ButtonPage() {
  return (
    <div>
      <div>
        <Button primary className="mb-2">
          <GoBell />
          Rounded
        </Button>
      </div>
      <div>
        <Button secondary>
          <GoCloudDownload />
          asdf
        </Button>
      </div>
      <div>
        <Button warning>Click me!</Button>
      </div>
      <div>
        <Button primary rounded outline>
          Click me!
        </Button>
      </div>
      <div>
        <Button secondary outline>
          Click me!
        </Button>
      </div>
      <div>
        <Button success outline>
          Click me!
        </Button>
      </div>
      <div>
        <Button danger outline>
          <GoCloudDownload />
          Click me!
        </Button>
      </div>
    </div>
  );
}

export default ButtonPage;
