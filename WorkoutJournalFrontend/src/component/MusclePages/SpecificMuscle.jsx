import React, { useState, useEffect } from "react";
import { useParams } from "react-router-dom";
import { BrowserRouter as Router, Link } from "react-router-dom"

import SMuscleList from "./SMuscleList";
import CustomButton from "../CustomButton";
import useFetch from "../../ApiStore/useFetch";


import '../../cssFolder/SpecificMuscle-style.css'

function SpecificMuscle(props) {

    let { id } = useParams();
    //const newTitle = props.items.filter(t => t.id == id)
    //const currentMuscle = newTitle.map(s => s.title)

    const {data, loading, error} = useFetch(`https://localhost:44314/${id}`)

    if(loading) return <h1>Loading..</h1>

    return (
        <div>
            {/* <h1>Muscle: {currentMuscle}</h1> */}
            <Link to="/muscles">
                <CustomButton 
                className = "addExerciseBtn"
                content={"Return to Musclepage"}/>
            </Link>
            <h2>Muscle Details</h2>
            <div className="mainDivSMuscle">
                <ul className="muscleUl">
                    {
                    data?.map((d) =>
                            <div className="sMuscleInnerDiv">
                                <div>
                                    <SMuscleList
                                        key={d.id}
                                        title={d.name}
                                        id={d.id}
                                        addExercise={props.addExercise}
                                    />
                                </div>
                            </div>
                        )
                        }
                </ul>
            </div>
        </div>
    )

}

export default SpecificMuscle;