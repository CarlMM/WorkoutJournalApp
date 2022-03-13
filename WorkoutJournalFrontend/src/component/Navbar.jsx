import React, {useState, useEffect} from 'react'
import {
  BrowserRouter as Router,
  Switch,
  Route,
  Link
} from "react-router-dom"


import Home from './Home'
import MyProfilePage from './MyProfile/MyProfilePage'

function Navbar(){

 const [counter, setCounter] = useState(0);

   useEffect(() => {
     const interval = setInterval(() => {
       setCounter((<p>It is {new Date().toLocaleTimeString()}.</p>));
     }, 1000);

     return () => clearInterval(interval);
   }, []);

  return(
    <Router>
    <div>
        <div class="topNav">
          <nav>
            {counter}
            <Link to="/">Home</Link>
            <Link to="/myProfilePage">My Profile</Link>
          </nav>
        </div>
        <Switch>
          <Route exact path="/">
            <Home/>
          </Route>
          <Route path="/myProfilePage">
            <MyProfilePage/>
          </Route>
        </Switch>
      </div>
   </Router>

  )
}


export default Navbar