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
]

function App() {

  //For further reference
  const [myExercises, setMyExercises] = useState([]);
  const [muscleList, setMuscleList] = useState(musclesGroupsList);
  const [isolatedMuscle, setisolatedMuscleList] = useState(isolatedMuscleList);

    return (
      <Navbar items={muscleList} sMuscle={isolatedMuscle}/>
  )
}

export default App
