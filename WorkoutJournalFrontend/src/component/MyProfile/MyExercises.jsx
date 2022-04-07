import react from "react";

import sMuscle from '../SpecificMuscle'

function MyExercises(props){



    const myStoredE = () =>{
        console.log(props.savedExercises)
    }

    return(
        <div>
            <h1>My saves exercises</h1>
            <ul>
                {props.savedExercises.map(s => <div>
                    <p>{s.title}</p><button></button>
                </div>)}
            </ul>
            <button onClick={myStoredE}>My Exercises</button>
        </div>
    )
}

export default MyExercises;