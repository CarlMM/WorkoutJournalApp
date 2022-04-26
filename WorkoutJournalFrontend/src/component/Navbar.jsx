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
import CustomButton from './CustomButton'

import '../cssFolder/Navbar-style.css'


function Navbar(props) {


  const [visible, setVisible] = useState(false);
  const [showProfile, setShowProfile] = useState(false);

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
          <div className="sideBarDiv">
            <ul className="arrowUl" onClick={showSidebar}>
              <FaIcons.FaArrowLeft className="menu-bars" />
            </ul>
            <ul className="nav-menu-items" onClick={showSidebar}>
              <li className="nav-text">
                <Link to="/">Home</Link>
              </li>
              {/* <li className="nav-text">
                <Link to="/myProfilePage">My Profile</Link>
              </li> */}
              <li className="nav-text">
                <Link to="/muscles">MuscleGroups</Link>
              </li>
              {/* <li className="nav-text">
                <Link to="/myExercises">My Exercises</Link>
              </li>
              <li className="nav-text">
                <Link to="/">My Routines</Link>
              </li> */}
              
            </ul>
            {!showProfile &&
            <CustomButton 
            className="addExerciseBtn"
            content={'Log in'}
            onClick={() => setShowProfile(true)}
            />
            }
            {showProfile && 
            <div>
              <ul onClick={showSidebar}>
              <li className="nav-text">
                <Link to="/myProfilePage">My Profile</Link>
                <li className="nav-text">
                <Link to="/myExercises">My Exercises</Link>
              </li>
              <li className="nav-text">
                <Link to="/">My Routines</Link>
              </li>
                <button onClick={() => setShowProfile(false)}>Log out</button>
              </li>
            </ul>
            </div>
            }
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