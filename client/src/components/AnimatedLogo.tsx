import Splash from '../svg/AnimatedLogo.svg';

export default function AnimatedLogo() {
  return (
    <div style={{width:'100px', position: 'fixed', bottom: '50px', right:'50px'}}>
      <img src={Splash} alt="Logo" />
    </div>
  );
}
