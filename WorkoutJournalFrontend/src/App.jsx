import React from 'react'
import {
  BrowserRouter as Router,
  Switch,
  Route,
  Link
} from "react-router-dom"

import Home from './component/Home';
import MyProfilePage from './component/MyProfile/MyProfilePage'

function App() {
  

  return (
    <Router>
      <div>
        <nav>
          <Link to="/">Home</Link>
          <Link to="/myProfilePage">My Profile</Link>
        </nav>
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
