import React, { useState, useEffect } from "react";


import CustomButton from "../CustomButton";

function SMuscleList(props){

    const [buttonText, setButtonText] = useState("Add")

    const check = () =>{
        console.log(props)
    }

    const isAdded = () =>{
        setButtonText("Added!")
    }

    return(
            <div>
                <h4>{props.title}</h4>
                <CustomButton 
                onClick={() => {props.addExercise({id: props.id, title: props.title}); isAdded();}}
                content={buttonText} 
                title={props.title} 
                id={props.id} 
                />
            </div>
    )
}

export default SMuscleList;