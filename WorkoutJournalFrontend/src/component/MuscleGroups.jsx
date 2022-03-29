import react from "react";
import { useHistory } from "react-router-dom";
import {
    BrowserRouter as Router,
    Switch,
    Route,
    Link,

} from "react-router-dom"

import SpecificMuscle from "./SpecificMuscle";

function MuscleGroups(props) {
    const checkMuscles = () => {
        console.log(props.items)
    }

    //let navigate = useHistory();
    const loopMusclesList = props.items.map((m) =>
        <li>
            <Link to={`/muscles/${m.id}`} key={m.id}>{m.title}</Link>
        </li>
    );



    return (
        <Router>

        <div>
            <h1>MuscleGroups</h1>
            <nav>
                <ul>
                    {loopMusclesList}
                </ul>
            </nav>
        </div>
            <Route exact path="/muscles/:id">
            <SpecificMuscle/>
          </Route>
        </Router>
    )

}

export default MuscleGroups;