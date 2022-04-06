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

    let history = useHistory();

    //let navigate = useHistory();
    const loopMusclesList = props.items.map((m) =>
        <li key={m.id}>
            <Link onClick={() => history.push(`/muscles/${m.id}`)} >{m.title}</Link>
        </li>
    );



    return (

        <div>
            <h1>MuscleGroups</h1>
            <nav>
                <ul>
                    {loopMusclesList}
                </ul>
            </nav>
        </div>
            
    )

}

export default MuscleGroups;