import React, { useState, useEffect } from "react";
import { useParams } from "react-router-dom";

import SMuscleList from "./SMuscleList";


function SpecificMuscle(props){


    let {id} = useParams();

    const filterMuscleExercises = () => {
        const newList = props.sMuscle.filter(sM => sM.muscleCateogryId == id)
        console.log(newList)
    }

    return(
        <div>
            <h1>Muscle id</h1>
            <h2>Muscle Details</h2>
            <h3>id: {id}</h3>
            <ul>
                {props.sMuscle.filter(s => s.muscleCateogryId == id)
                .map(filteredArray => (<li>{filteredArray.title}</li>))}
            </ul>
        </div>
    )

}

export default SpecificMuscle;