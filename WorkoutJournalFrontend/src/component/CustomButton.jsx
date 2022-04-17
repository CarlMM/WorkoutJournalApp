import react from "react";



function CustomButton(props){

    // props.addExercise(props); 
    //props.changeText(props.id)
   
    return(
        <div>
            <button className="addExerciseBtn" 
            onClick={props.onClick}>
                <p>{props.content}</p>
            </button>
        </div>
    )

}


export default CustomButton;