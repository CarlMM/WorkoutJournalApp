import React, {useState, useEffect} from 'react'

import {
  BrowserRouter as Router,
  Switch,
  Route,
  Link
} from "react-router-dom"

import Home from './component/Home';
import MyProfilePage from './component/MyProfile/MyProfilePage'
//import Navbar from './component/Navbar'




function App() {
  
  const [counter, setCounter] = useState(0);

  useEffect(() => {
    const interval = setInterval(() => {
      setCounter((<p>It is {new Date().toLocaleTimeString()}.</p>));
    }, 1000);

    return () => clearInterval(interval);
  }, []);
    
    return (
      <Router>
      <div>
        <div class="topNav">
          <nav>
            {/* {tick()} */}
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

export default App
