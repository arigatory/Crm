// import { useState } from 'react';
// import { AiOutlineCompass, AiOutlineClockCircle } from 'react-icons/ai';
// import { RxPerson } from 'react-icons/rx';
// import { IconInfo } from '../components/IconInfo';
// import { BiRuble } from 'react-icons/bi';
// import { IoLocationOutline } from 'react-icons/io5';

function Dashboard() {
  // const [gameEvents, setGameEvents] = useState([]);

  // useEffect(() => {
  //   axios
  //     .get(`${import.meta.env.VITE_APP_API_URL}/game-events `)
  //     .then((response) => {
  //       console.log(response.data);
  //       setGameEvents(response.data);
  //     });
  // }, []);

  // function formatDate(dateString: string): string {
  //   const date = new Date(dateString);
  //   const formattedDate = `${date.getDate()}.${
  //     date.getMonth() + 1
  //   }.${date.getFullYear()}`;
  //   return formattedDate;
  // }

  // function formatTime(dateString: string): string {
  //   const date = new Date(dateString);
  //   const hours = date.getHours();
  //   const minutes = date.getMinutes();
  //   const formattedTime = `${hours < 10 ? '0' : ''}${hours}:${
  //     minutes < 10 ? '0' : ''
  //   }${minutes}`;
  //   return formattedTime;
  // }

  // const renderedCards = gameEvents?.map((gameEvent: any) => (
  //   <div
  //     className="bg-white r-30 rounded-3xl p-4 cursor-pointer mb-4 group hover:bg-rbggreen"
  //     key={gameEvent.id}
  //   >
  //     <div className="text-xs text-rbgblue font-semibold group-hover:text-white">
  //       {formatDate(gameEvent.date)}
  //     </div>
  //     <div className="text-base font-bold mb-3 group-hover:text-white">
  //       {gameEvent.boardGame}
  //     </div>
  //     <div className="grid grid-rows-2 grid-cols-2 w-1/2">
  //       <IconInfo
  //         text={formatTime(gameEvent.date)}
  //         icon={AiOutlineClockCircle}
  //         className="group-hover:text-white"
  //       />
  //       <IconInfo
  //         text={`${gameEvent.currentNumberOfPlayers} / ${gameEvent.maxNumberOfPlayers}`}
  //         icon={RxPerson}
  //       />
  //       <IconInfo text={gameEvent.price} icon={BiRuble} />
  //       <IconInfo
  //         text={`${gameEvent.distanceFromVenue} км`}
  //         icon={IoLocationOutline}
  //       />
  //     </div>
  //   </div>
  // ));
  return (
    <div className=" bg-gray-100 p-4  pb-80">
      <h1 className="flex justify-center align-middle items-center font-bold text-lg mb-10">
        {/* <AiOutlineCompass className="mr-1 text-rbggreen font-bold text-2xl" />{' '} */}
        <span>Игры поблизости</span>
      </h1>
    </div>
  );
}

export default Dashboard;
