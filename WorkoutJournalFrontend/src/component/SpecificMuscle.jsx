import React, { useState, useEffect } from "react";
import { useParams } from "react-router-dom";


function SpecificMuscle(props){


    let {id} = useParams();

    return(
        <div>
            <h1>Muscle id</h1>
            <h2>Muscle Details</h2>
            <h3>id: {id}</h3>
        </div>
    )



}

export default SpecificMuscle;