import React, { useState, useEffect } from "react";


import CustomButton from "../CustomButton";

function SMuscleList(props){

    const [buttonText, setButtonText] = useState("Add")

    const check = () =>{
        console.log(props)
    }

    const isAdded = (id) =>{
        setButtonText("Added!")
    }


    return(
            <div>
                <h4>{props.title}</h4>
                <CustomButton 
                content={buttonText} 
                title={props.title} 
                id={props.id} 
                addExercise={props.addExercise}
                changeText={isAdded}/>
            </div>
    )
}

export default SMuscleList;