import React, {useState, useEffect} from 'react'
import './Header.css'

const Header = () => {
    const [currentTime, setCurrentTime] = useState(new Date().toLocaleTimeString());

    useEffect(() => {
        const timer = setInterval(() => {
            setCurrentTime(new Date().toLocaleTimeString());
        }, 1000)

        return () => clearInterval(timer);
    }, [])

    return (
        <div className='Header'>
            <div className='Header-left'>
                <h1>Simple Weather App</h1>
            </div>
            <div className='Header-center'>
                <button className='Header-button'>Units</button>
                <button className='Header-button'>Advanced</button>
                <button className='Header-button'>Option 1</button>
            </div>
            <div className='Header-right'>
                <h2>{currentTime}</h2>
            </div>
        </div>
    )
}

export default Header