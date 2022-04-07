import react from "react";


import '../../cssFolder/MyProfileCard-style.css'


function MyProfileCard(props){


    return(
        <div>
            <div className="mainCardDiv">
                <img src={props.pic}/>
                <div>
                    <h2>{props.name}</h2>
                    <p>Hobby: {props.hobby}</p>
                </div>
            </div>
        </div>
    )
}

export default MyProfileCard