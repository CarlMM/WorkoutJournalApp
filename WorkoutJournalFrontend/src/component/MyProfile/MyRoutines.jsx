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

    const{data, loading, error, setData} = useFetch(url)
    const [name, setRoutineName] = useState("")

   const updateMyRoutineList = () =>{
    axios.get(url).then((response) => {
        setData(response.data)
        console.log('inne i useFetch')
    })
   }
    
    const postNewRoutine = async (e) =>{
        e.preventDefault()
        console.log(name)
        try{
            const response = await axios.post(url, {name});
            console.log(response)
            updateMyRoutineList()
        }catch(error){
             console.log(error.response)
         }
    }

      //useEffect(() => {
        //   console.log('useeffect routine')
        //   console.log(theApiList)
        //     setTheApiList(data)
        //     console.log(theApiList)
      //}, [])

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