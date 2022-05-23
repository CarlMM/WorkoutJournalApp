import React, { useState, useEffect, useReducer } from "react";
import useFetch from "../../ApiStore/useFetch";
import { useParams } from "react-router-dom";
import { BrowserRouter as Router, Link } from "react-router-dom"

function SpecificRoutine(){
    let {id} = useParams();
    const url = `https://localhost:44314/api/WorkoutExercise/workoutExerciseRoutineId/${id}`
    
    const{data, loading, error, setData} = useFetch(url)

    return(
        <div>
            <h1>ROUTINEID: {id}</h1>
            
            <ul>
            {data &&
                    data.map((mr) => 
                    <div>
                            <li key={mr.id}>
                                <p>{mr.exercise}</p>
                            </li>
                        </div>
                    )
                }
                </ul>
        </div>
    )
}

export default SpecificRoutine;