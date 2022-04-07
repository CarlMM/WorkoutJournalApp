import React from "react"

import './CardStyle.css'

function Card(props){

    const classes = 'card ' + props.className;

    return(
        <div className={classes}>
            {props.children}
        </div>
    )
}

export default Card;