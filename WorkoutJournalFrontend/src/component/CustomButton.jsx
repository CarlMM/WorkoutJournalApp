import react from "react";



function CustomButton(props){

    
    const check = () => {
        console.log(props.id)
        console.log(props.title)
        
    }

    return(
        <div>
            <button className="addExerciseBtn" onClick={() => { props.addExercise(props); props.changeText(props.id)}}>
                <p>{props.content}</p>
            </button>
        </div>
    )

}


export default CustomButton;