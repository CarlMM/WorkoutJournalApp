import react, {useEffect, useState } from "react";
import axios from 'axios'

const url = "https://localhost:44314/api/Routine"
//https://localhost:44314/api/Routine

function usePostRoutine(routineName){
    const [value, setValue] = useState();

    useEffect(() => {
        try{
            const response = axios.post(url, {routineName});
            console.log(response.data)
            setValue(response.data)
        }catch(error){
            console.log(error.response)
        }

    }, [])

    return {value}

}

export default usePostRoutine;