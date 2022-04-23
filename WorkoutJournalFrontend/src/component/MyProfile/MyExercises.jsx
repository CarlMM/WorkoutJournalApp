import React, { useState, useEffect } from "react";

import sMuscle from '../MusclePages/SpecificMuscle'

import CustomButton from "../CustomButton";

function MyExercises(props){


    const [buttonText, setButtonText] = useState("Remove")


    return(
        <div>
            <h1>My saved exercises</h1>
            <ul>
                {props.savedExercises.map(s => <div>
                    <p>{s.title}</p>
                    <CustomButton
                    className="removeExerciseBtn" 
                    onClick={() => props.removeExercise(s)}
                    content={buttonText}/>
                </div>)}
            </ul>
        </div>
    )
}

export default MyExercises;