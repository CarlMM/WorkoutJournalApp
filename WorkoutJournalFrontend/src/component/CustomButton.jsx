import react from "react";

import '../cssFolder/CustomBtn-style.css'


function CustomButton(props){

   const classes = 'CustomButton ' + props.className;
   
    return(
        <div>
            <button className={classes}
            onClick={props.onClick}>
                <p>{props.content}</p>
            </button>
        </div>
    )

}


export default CustomButton;