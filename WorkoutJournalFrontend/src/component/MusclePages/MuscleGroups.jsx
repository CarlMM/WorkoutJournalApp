import react from "react";
import { useHistory } from "react-router-dom";
import {
    BrowserRouter as Router,
    Switch,
    Route,
    Link,

} from "react-router-dom"


import '../../cssFolder/MuscleGroups-style.css'

function MuscleGroups(props) {

    return (
        <div className="mainDiv">
            <h1>MuscleGroups</h1>
            <div className="muscleMainDiv">
                <ul className="muscleUl">
                    {
                        props.items.map((m) =>
                            <div className="muscleInnerDiv">
                                <li key={m.id} className="muscleNav-text">
                                    <Link to={`/muscles/${m.id}`}>{m.title}</Link>
                                </li>
                            </div>
                        )}
                </ul>
            </div>
        </div>

    )

}

export default MuscleGroups;