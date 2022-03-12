import React from 'react'
import {
  BrowserRouter as Router,
  Switch,
  Route,
  Link
} from "react-router-dom"


function Navbar(){
    <Router>
      <div>
        <div class="topNav">
          <nav>
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
}


export default Navbar