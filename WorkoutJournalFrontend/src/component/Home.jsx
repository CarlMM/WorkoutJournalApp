import React, {useState, useEffect} from 'react'
import '../cssFolder/Home-style.css'

const weekDays = [
    "Söndag", 
    "Måndag", 
    "Tisdag", 
    "Onsdag", 
    "Torsdag", 
    "Fredag", 
    "Lördag"
]


function Home(){

    const [clock, setCounter] = useState(0);
    const [currentDay, setCurrentDay] = useState('')
    const [currentNumberDay, setCurrentNumberDay] = useState();
    const [dailyQuote, setDailyQuote] = useState('');

    const whatQuoteToday = (currentNumberDay) =>{
        switch(currentNumberDay){
            case 0:
            return 'On sunday, we rest';
            case 1:
            return `Of course i'ts chest today!`;
            case 2:
            return 'Gains going up on a tuesday!';
            case 3:
            return 'Onsdag idag? Det betyder ben!';
            case 4:
            return 'Gorilla back thursday';
            case 5:
            return 'Discofredag på schemat!';
            case 6:
            return 'Saturday';

        }

    }

  
    useEffect(() => {
      const interval = setInterval(() => {
        setCounter((<p>It is {new Date().toLocaleTimeString()}.</p>));
      }, 1000);

      return () => clearInterval(interval);
    }, []);

    useEffect(() => {
          const whatDay = new Date();
          const weekdayNumber = whatDay.getDay();
          const dayName = weekDays[weekdayNumber]
          setCurrentDay(dayName)
          setCurrentNumberDay(weekdayNumber)
          const quote = whatQuoteToday(currentNumberDay)
          setDailyQuote(quote)
      }, [currentNumberDay]);

    

    return (
        <div className='line'>
            <div className='lineUp'>
                <h1 className='homeScreenH1'>{currentDay}</h1>
                <div>{clock}</div>
                {dailyQuote}
            </div>
        </div>
    )
}

export default Home