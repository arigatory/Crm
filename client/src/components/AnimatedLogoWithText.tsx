import Splash from '../svg/AnimatedLogo.svg';
import RbgLogoText from '../svg/RbgLogoText.svg';

export default function AnimatedLogoWithText() {
  return (
    <div
      style={{ height: '100%' }}
      className="flex flex-col content-center items-center p-10 justify-center"
    >
      <img
        src={Splash}
        alt="Logo"
        style={{ width: '50%', maxHeight: '50%'  }}
      />
      <img
        src={RbgLogoText}
        alt="LogoText"
        style={{ width: '50%', maxHeight: '50%' }}
      />
    </div>
  );
}
