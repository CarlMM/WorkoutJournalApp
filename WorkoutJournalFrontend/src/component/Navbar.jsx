import React, {useState, useEffect} from 'react'
import {
  BrowserRouter as Router,
  Switch,
  Route,
  Link
} from "react-router-dom"


import Home from './Home'
import MyProfilePage from './MyProfile/MyProfilePage'
import MuscleGroups from './MuscleGroups'
import SpecificMuscle from './SpecificMuscle'
import MyExercises from './MyProfile/MyExercises'



  





function Navbar(props){
  
  
  const [counter, setCounter] = useState(0);
  
  useEffect(() => {
    const interval = setInterval(() => {
      setCounter((<p>It is {new Date().toLocaleTimeString()}.</p>));
    }, 1000);
    
    return () => clearInterval(interval);
  }, []);
  
  
  const [visible, setVisible] = React.useState(false);

  const myStoredE = () =>{
    console.log(props.exercises)
}
  
  return(
    <Router>
    <div>
      {!visible &&
    <div>
      <button onClick={() => setVisible(true)}>Login</button>
      <button onClick={myStoredE}>My Exercises</button>
    </div>
      }
    {visible && 
        <div className="topNav">
          <nav>
            <Link to="/">Home</Link>
            <Link to="/myProfilePage">My Profile</Link>
            <Link to="/myExercises">My Exercises</Link>
            <Link to="/muscles">MuscleGroups</Link>
            <button onClick={() => setVisible(false)}>Log out</button>
          </nav>
        </div>
      }
        <Switch>
          <Route exact path="/">
            <Home/>
          </Route>
          <Route path="/myProfilePage">
            <MyProfilePage/>
          </Route>
          <Route path="/myExercises">
            <MyExercises savedExercises={props.exercises}/>
          </Route>
          <Route exact path="/muscles">
            <MuscleGroups items={props.items}/>
          </Route>
          <Route path="/muscles/:id">
            <SpecificMuscle sMuscle={props.sMuscle} items={props.items} />
          </Route>
        </Switch>
      </div>
   </Router>

  )
}


export default Navbar