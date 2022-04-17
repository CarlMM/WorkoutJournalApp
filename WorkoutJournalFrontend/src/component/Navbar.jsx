import React, { useState, useEffect } from 'react'
import {
  BrowserRouter as Router,
  Switch,
  Route,
  Link
} from "react-router-dom"
import * as FaIcons from 'react-icons/fa'


import Home from './Home'
import MyProfilePage from './MyProfile/MyProfilePage'
import MuscleGroups from './MusclePages/MuscleGroups'
import SpecificMuscle from './MusclePages/SpecificMuscle'
import MyExercises from './MyProfile/MyExercises'

import '../cssFolder/Navbar-style.css'


function Navbar(props) {


  const [visible, setVisible] = useState(false);

  const showSidebar = () => {
    setVisible(!visible)
  }

  return (
    <Router>
      <div>
        <div className="menu-bars">
          <FaIcons.FaBars  onClick={showSidebar} />
        </div>
        <nav className={visible ? 'nav-menu active' : 'nav-menu'}>
          <div>
            <ul className="arrowUl" onClick={showSidebar}>
              <FaIcons.FaArrowLeft className="menu-bars" />
            </ul>
            <ul className="nav-menu-items" onClick={showSidebar}>
              <li className="nav-text">
                <Link to="/">Home</Link>
              </li>
              <li className="nav-text">
                <Link to="/myProfilePage">My Profile</Link>
              </li>
              <li className="nav-text">
                <Link to="/muscles">MuscleGroups</Link>
              </li>
              <li className="nav-text">
                <Link to="/myExercises">My Exercises</Link>
              </li>
              
            </ul>
          </div>
        </nav>
        <Switch>
          <Route exact path="/">
            <Home />
          </Route>
          <Route path="/myProfilePage">
            <MyProfilePage />
          </Route>
          <Route path="/myExercises">
            <MyExercises savedExercises={props.exercises} removeExercise={props.removeExercise} />
          </Route>
          <Route exact path="/muscles">
            <MuscleGroups items={props.items} />
          </Route>
          <Route path="/muscles/:id">
            <SpecificMuscle sMuscle={props.sMuscle}
              items={props.items}
              addExercise={props.addExercise} />
          </Route>
        </Switch>
      </div>
    </Router>

  )
}


export default Navbar