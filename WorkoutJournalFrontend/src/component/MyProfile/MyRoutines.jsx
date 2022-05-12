import React, { useState, useEffect } from "react";

import {
    BrowserRouter as Router,
    Switch,
    Route,
    Link,

} from "react-router-dom"


function MyRoutines(){

    const[myRoutines, setMyRoutines] = useState();

    const getRoutineData = async () => {
        const response = await fetch('https://localhost:44314/api/Routine')
        .then((response) => response.json())

        setMyRoutines(response)
    }

    useEffect(() => {
        getRoutineData();
    },[])

    return (
        <div>
            <div>
                <h1>Routines</h1>
                <ul>

                {myRoutines &&
                    myRoutines.map((mr) => 
                    <div>
                            <li key={mr.id}>
                                <Link>{mr.name}</Link>
                            </li>
                        </div>
                    )
                }
                </ul>

            </div>
        </div>
    )
}

export default MyRoutines