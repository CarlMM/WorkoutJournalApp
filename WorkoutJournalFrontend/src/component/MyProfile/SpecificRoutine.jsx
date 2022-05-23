import React, { useState, useEffect } from "react";
import { useParams } from "react-router-dom";
import { BrowserRouter as Router, Link } from "react-router-dom"

const url = `https://localhost:44314/api/WorkoutExercise/workoutExerciseRoutineId/${id}`
function SpecificRoutine(){

    let {id} = useParams();


    return(
        <div>
            <h1>ROUTINEID: {id}</h1>
        </div>
    )
}

export default SpecificRoutine;