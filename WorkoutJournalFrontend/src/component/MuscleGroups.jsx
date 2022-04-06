import react from "react";
import { useHistory } from "react-router-dom";
import {
    BrowserRouter as Router,
    Switch,
    Route,
    Link,

} from "react-router-dom"


function MuscleGroups(props) {
    
    const loopMusclesList = props.items.map((m) =>
        <li key={m.id}>
            <Link to={`/muscles/${m.id}`}>{m.title}</Link>
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