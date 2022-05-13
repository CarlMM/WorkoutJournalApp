import React, {useState, useEffect} from 'react'
import { useHistory } from "react-router-dom";
import {
    BrowserRouter as Router,
    Switch,
    Route,
    Link,

} from "react-router-dom"

import '../../cssFolder/MuscleGroups-style.css'
import useFetch from '../../ApiStore/useFetch';

function MuscleGroups() {

    const{data, loading, error} = useFetch('https://localhost:44314/api/Muscle')

    if(loading) return <h1>Loading..</h1>

    return (
        <div className="mainDiv">
            <h1>MuscleGroups</h1>
            <h3>Browse exercises</h3>
            <div className="muscleMainDiv">
                <ul className="muscleUl">
                    {
                        data?.map((m) => 
                        <div className="muscleInnerDiv">
                            <li key={m.id} className="muscleNav-text">
                            <Link to={`/muscles/${m.id}`}>{m.name}</Link>
                            </li>
                        </div>
                        )
                    }
                </ul>
            </div>
        </div>

    )

}

export default MuscleGroups;