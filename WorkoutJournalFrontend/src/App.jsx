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
]

function App() {
  const [muscleList, setMuscleList] = useState(musclesGroupsList);



    return (
      <Navbar items={muscleList}/>
  )
}

export default App
