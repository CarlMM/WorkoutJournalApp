import react from "react";



function MyExercises(props){



    const myStoredE = () =>{
        console.log(props.savedExercises)
    }

    return(
        <div>
            <h1>My saves exercises</h1>
            <button onClick={myStoredE}>My Exercises</button>
        </div>
    )
}

export default MyExercises;