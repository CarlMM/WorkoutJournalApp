import React, { useState, useEffect } from "react";


import CustomButton from "../CustomButton";

import '../../cssFolder/CustomBtn-style.css'

function SMuscleList(props){

    const [buttonText, setButtonText] = useState("Add")

    const isAdded = () =>{
        setButtonText("Added!")
    }

    return(
            <div>
                <h4>{props.title}</h4>
                <CustomButton 
                className = "addExerciseBtn"
                onClick={() => {props.addExercise({id: props.id, title: props.title}); isAdded();}}
                content={buttonText} 
                />
            </div>
    )
}

export default SMuscleList;