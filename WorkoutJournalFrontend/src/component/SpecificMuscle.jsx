import React, { useState, useEffect } from "react";
import { useParams } from "react-router-dom";

import SMuscleList from "./SMuscleList";


function SpecificMuscle(props) {
    
    let { id } = useParams();
    const newTitle = props.items.filter(t => t.id == id)
    const currentMuscle = newTitle.map(s => s.title)

    // const [currentMuscle, setCurrentMuscle] = useState('');

    // useEffect(() => {
    //     const newTitle = props.items.find(t => t.id == id)
    //     setCurrentMuscle(newTitle.title)
    // }, [])

    
    return (
        <div>
            <h1>Muskel: {currentMuscle}</h1>
            <h2>Muscle Details</h2>
            <h3>id: {id}</h3>
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