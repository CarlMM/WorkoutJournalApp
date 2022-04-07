import react from "react";

import sMuscle from '../MusclePages/SpecificMuscle'

function MyExercises(props){


    return(
        <div>
            <h1>My saves exercises</h1>
            <ul>
                {props.savedExercises.map(s => <div>
                    <p>{s.title}</p><button onClick={() => props.removeExercise(s)}>Remove</button>
                </div>)}
            </ul>
        </div>
    )
}

export default MyExercises;