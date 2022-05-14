import React, { useState, useEffect } from "react";
import useFetch from "../../ApiStore/useFetch";
import axios from 'axios'

import {
    BrowserRouter as Router,
    Switch,
    Route,
    Link,

} from "react-router-dom"

const url = "https://localhost:44314/api/Routine"
function MyRoutines(){

    const{data, loading, error} = useFetch('https://localhost:44314/api/Routine')
    const [name, setRoutineName] = useState("")

    
    const postNewRoutine = async (e) =>{
        e.preventDefault();
        console.log(name)

        try{
            const response = await axios.post(url, {name: name});
            console.log(response.data)
        }catch(error){
            console.log(error.response)
        }
    }



    useEffect(() => {
        
    },[data])


  




    return (
        <div>
            <div>
                <h1>Routines</h1>
                <form onSubmit={postNewRoutine}>
                    <input value={name} onChange={(e) => setRoutineName(e.target.value)} type="text" />
                    <button>Lägg till</button>
                </form>


                <ul>

                {data &&
                    data.map((mr) => 
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