import React from 'react'

import MyProfileCard from './MyProfileCard'
import Card from '../UI/Card'


import '../../cssFolder/MyProfilePageStyle.css'

const DUMMY_PROFILE = [
    {
        id:1,
        name: 'StrongCarl100',
        pic: 'https://c.tenor.com/FmxyObFLPl0AAAAd/strong-tough.gif',
        hobby: 'Lifting weights'
    }
]

function MyProfilePage(){


    return (
    <div className='mainDiv'>
        <h1>This is ur profilePage</h1>
        <ul>
            {DUMMY_PROFILE.map(p =>
                <Card className="listItems">
                    <MyProfileCard 
                    key={p.id}
                    name={p.name}
                    pic={p.pic}
                    hobby={p.hobby}
                    />
                </Card>
            )}
        </ul>
        {/* <ul>
            <Card className="">
                <MyProfileCard
                name={DUMMY_PROFILE.name}/>
            </Card>
        </ul> */}
    </div>
    )
}

export default MyProfilePage