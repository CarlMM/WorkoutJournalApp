import React, { useState, useEffect } from "react";


import CustomButton from "../CustomButton";

function SMuscleList(props){

    const [buttonText, setButtonText] = useState("Add")

    const isAdded = () =>{
        setButtonText("Added!")
    }

    return(
            <div>
                <h4>{props.title}</h4>
                <CustomButton 
                onClick={() => {props.addExercise({id: props.id, title: props.title}); isAdded();}}
                content={buttonText} 
                />
            </div>
    )
}

export default SMuscleList;