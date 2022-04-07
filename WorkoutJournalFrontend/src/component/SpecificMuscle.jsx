import React, { useState, useEffect } from "react";
import { useParams } from "react-router-dom";

import SMuscleList from "./SMuscleList";


function SpecificMuscle(props) {
    
    let { id } = useParams();
    const newTitle = props.items.filter(t => t.id == id)
    const currentMuscle = newTitle.map(s => s.title)

    return (
        <div>
            <h1>Muscle: {currentMuscle}</h1>
            <button>Return to Musclepage</button>
            <h2>Muscle Details</h2>
            <ul>
                {props.sMuscle.filter(s => s.muscleCateogryId == id)
                    .map(s =>
                    (

                        <SMuscleList
                        key={s.id}
                        title={s.title}  
                        />
                    ))}
            </ul>
        </div>
    )

}

export default SpecificMuscle;