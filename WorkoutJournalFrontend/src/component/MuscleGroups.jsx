import react from "react";


function MuscleGroups(props){

    const checkMuscles = () => {
        console.log(props.items)
    }

    const loopMusclesList = props.items.map((m) => 
        <li>
            {m.title}
        </li>
    );

    return(
        <div>
            <h1>MuscleGrous</h1>
            <button onClick={checkMuscles}>Muscles</button>
            <ul>
                {loopMusclesList}
            </ul>
        </div>
    )

}

export default MuscleGroups;