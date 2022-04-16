import React, { useState, useEffect } from "react";
import { useParams } from "react-router-dom";
import { BrowserRouter as Router, Link } from "react-router-dom"
import * as GrIcons from 'react-icons/GR'
import * as CgIcons from 'react-icons/CG'

import SMuscleList from "./SMuscleList";


import '../../cssFolder/SpecificMuscle-style.css'

function SpecificMuscle(props) {

    let { id } = useParams();
    const newTitle = props.items.filter(t => t.id == id)
    const currentMuscle = newTitle.map(s => s.title)


    return (
        <div>
            <h1>Muscle: {currentMuscle}</h1>
            <Link to="/muscles">
                <button>Return to Musclepage</button>
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
                                    />
                                </div>
                                <div>
                                    <button className="addExerciseBtn" onClick={() => props.addExercise(s)}>
                                        Add Exercise
                                    {/* <CgIcons.CgAdd className="addIcon"/> */}
                                    {/* <GrIcons.GrAdd/> */}
                                </button>
                                </div>
                            </div>
                        ))}

                </ul>
            </div>
        </div>
    )

}

export default SpecificMuscle;