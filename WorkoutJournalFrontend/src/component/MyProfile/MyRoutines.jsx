import React, { useState, useEffect, useReducer } from "react";
import useFetch from "../../ApiStore/useFetch";
import usePostRoutine from "../../ApiStore/usePostRoutine";
import axios from 'axios'

import {
    BrowserRouter as Router,
    Switch,
    Route,
    Link,

} from "react-router-dom"

const url = "https://localhost:44314/api/Routine"
function MyRoutines(){


    const{data, loading, error} = useFetch(url)
    const [name, setRoutineName] = useState("")

   const updateMyRoutineList = async () =>{
        data = await axios.get(url).then(response);
   }
    
    const postNewRoutine = async (e) =>{
        e.preventDefault();
        console.log(name)
       
         try{
             const response = await axios.post(url, {name});
             console.log(response.data)
            
        }catch(error){
             console.log(error.response)
         }
    }

    //  useEffect(() => {

    //  }, [data])

    return (
        <div>
            <div>
                <h1>Routines</h1>
                <form onSubmit={postNewRoutine}>
                    <input value={name} onChange={(e) => setRoutineName(e.target.value)} type="text" />
                    <button>Add routine</button>
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