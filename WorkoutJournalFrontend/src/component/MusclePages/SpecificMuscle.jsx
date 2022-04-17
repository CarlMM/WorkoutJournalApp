import React, { useState, useEffect } from "react";
import { useParams } from "react-router-dom";
import { BrowserRouter as Router, Link } from "react-router-dom"

import SMuscleList from "./SMuscleList";
import CustomButton from "../CustomButton";


import '../../cssFolder/SpecificMuscle-style.css'

function SpecificMuscle(props) {

    let { id } = useParams();
    const newTitle = props.items.filter(t => t.id == id)
    const currentMuscle = newTitle.map(s => s.title)

    return (
        <div>
            <h1>Muscle: {currentMuscle}</h1>
            <Link to="/muscles">
                <CustomButton content={"Return to Musclepage"}/>
            </Link>
            <h2>Muscle Details</h2>
            <div className="mainDivSMuscle">
                <ul className="muscleUl">
                    {props.sMuscle.filter(s => s.muscleCateogryId == id)
                        .map(s =>
                        (
                            <div className="sMuscleInnerDiv">
                                <div>
                                    <SMuscleList
                                        key={s.id}
                                        title={s.title}
                                        id={s.id}
                                        addExercise={props.addExercise}
                                    />
                                </div>
                                {/* <div>
                                    <button className="addExerciseBtn" onClick={() => { props.addExercise(s); isAdded(s.id); }}>
                                        <p>{buttonText}</p>
                                    </button>
                                </div> */}
                            </div>
                        ))}
                </ul>
            </div>
        </div>
    )

}

export default SpecificMuscle;