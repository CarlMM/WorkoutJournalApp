import React from 'react'
import {
  BrowserRouter as Router,
  Switch,
  Route,
  Link
} from "react-router-dom"

import Home from './component/Home';

function App() {
  

  return (
    <Router>
      <div>
        <nav>
          <Link to="/">Home</Link>
          <Link to="/myPage">My Profile</Link>
        </nav>
        <Switch>
          <Route path="/">
            <Home/>
          </Route>
        </Switch>
      </div>
    </Router>
  )
}

export default App
