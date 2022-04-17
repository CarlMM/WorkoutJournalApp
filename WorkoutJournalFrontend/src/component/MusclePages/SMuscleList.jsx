import React, { useState, useEffect } from "react";


import CustomButton from "../CustomButton";

function SMuscleList(props){

    const check = () =>{
        console.log(props)
    }


    return(
            <div>
                <h4>{props.title}</h4>
                <CustomButton title={props.title} id={props.id} addExercise={props.addExercise}/>
            </div>
    )
}

export default SMuscleList;