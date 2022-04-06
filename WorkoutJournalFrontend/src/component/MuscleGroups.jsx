import react from "react";
import { useHistory } from "react-router-dom";
import {
    BrowserRouter as Router,
    Switch,
    Route,
    Link,

} from "react-router-dom"

import SpecificMuscle from "./SpecificMuscle";


const isolatedMuscleList = [
    {
      id: 1,
      muscleCateogryId: 1,
      title: 'BenchPress',
    },
    {
      id: 2,
      muscleCateogryId: 1,
      title: 'Incline BenchPress',
    },
    {
      id: 3,
      muscleCateogryId: 3,
      title: 'Squats',
    },
    {
      id: 4,
      muscleCateogryId: 5,
      title: 'BicepsCurl',
    },
    
  ]

function MuscleGroups(props) {
    const checkMuscles = () => {
        console.log(props.items)
    }

    let history = useHistory();

    //let navigate = useHistory();
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
            <button onClick={checkMuscles}>Tja</button>
        </div>
            
    )

}

export default MuscleGroups;