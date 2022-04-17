import react from "react";



function CustomButton(props){

    
    const check = () => {
        console.log(props.id)
        console.log(props.title)
        
    }

    return(
        <div>
            <button onClick={() => { props.addExercise(props)}}>
                <p>Add</p>
            </button>
        </div>
    )

}


export default CustomButton;