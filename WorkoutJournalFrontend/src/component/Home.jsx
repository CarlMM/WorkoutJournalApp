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
  
    useEffect(() => {
      const interval = setInterval(() => {
        setCounter((<p>It is {new Date().toLocaleTimeString()}.</p>));
      }, 1000);
      
        const whatDay = new Date();
        const weekdayNumber = whatDay.getDay();
        const dayName = weekDays[weekdayNumber]
        setCurrentDay(dayName)

      return () => clearInterval(interval);
    }, []);

    const fetchDay = () =>{
        const today = new Date()

        console.log(today.getDay())
    }

   

    return (
        <div>
            <h1>{currentDay}</h1>
            {clock}
            <button onClick={fetchDay}>FetchDag</button>
        </div>
    )
}

export default Home