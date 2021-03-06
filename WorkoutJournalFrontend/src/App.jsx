import React, {useState, useEffect} from 'react'

// import {
//   BrowserRouter as Router,
//   Switch,
//   Route,
//   Link
// } from "react-router-dom"

//import Home from './component/Home';
//import MyProfilePage from './component/MyProfile/MyProfilePage'
import Navbar from './component/Navbar'



const musclesGroupsList = [
  {
    id: 1,
    title: 'Chest',
  },
  {
    id: 2,
    title: 'Back',
  },
  {
    id: 3,
    title: 'Legs',
  },
  {
    id: 4,
    title: 'Shoulders',
  },
  {
    id: 5,
    title: 'Arms',
  },
  {
    id: 6,
    title: 'Abs',
  },
];

const isolatedMuscleList = [
  {
    id: 1,
    muscleCateogryId: 1,
    title: 'BenchPress',
  },
  {
    id: 2,
    muscleCateogryId: 1,
    title: 'Incline BenchPress',
  },
  {
    id: 3,
    muscleCateogryId: 3,
    title: 'Squats',
  },
  {
    id: 4,
    muscleCateogryId: 5,
    title: 'BicepsCurl',
  },
  {
    id: 5,
    muscleCateogryId: 1,
    title: 'Dips',
  },
  {
    id: 6,
    muscleCateogryId: 1,
    title: 'Incline Flies',
  },
  {
    id: 7,
    muscleCateogryId: 1,
    title: 'Chest Flies',
  },
  {
    id: 8,
    muscleCateogryId: 1,
    title: 'Dumbell press',
  },
  {
    id: 9,
    muscleCateogryId: 1,
    title: 'Cable crossover',
  },
  {
    id: 10,
    muscleCateogryId: 1,
    title: 'Pushups',
  },
]

const LOCAL_STORAGE_KEY = 'myStoredExercises'

function App() {

  //For further reference
  const [myExercises, setMyExercises] = useState([]);
  const [muscleList, setMuscleList] = useState(musclesGroupsList);
  const [isolatedMuscle, setisolatedMuscleList] = useState(isolatedMuscleList);



    useEffect(() =>{
      localStorage.setItem(LOCAL_STORAGE_KEY, JSON.stringify(myExercises))
    }, [myExercises])

    useEffect(()=>{
      const myStoredExercises = JSON.parse(localStorage.getItem(LOCAL_STORAGE_KEY))
      if(myStoredExercises)
      setMyExercises(myStoredExercises)
      console.log(myStoredExercises)
    },[])


    const addExercise = (obj) =>{
      const exc = obj;
      console.log(exc)
      setMyExercises(oGList =>{return [...oGList, exc]})
      console.log(myExercises)
    }

    const removeExercise = (obj) => {
      const exc = obj;
      setMyExercises(oGList => {return [...oGList.filter(s => s!==exc)]})
      console.log(exc)
    }

    
    return (
      <Navbar items={muscleList} 
      sMuscle={isolatedMuscle} 
      exercises={myExercises}  
      addExercise={addExercise}
      removeExercise={removeExercise}/>
  )
}

export default App
