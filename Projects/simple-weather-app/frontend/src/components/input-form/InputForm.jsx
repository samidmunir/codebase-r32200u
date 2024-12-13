import { useState } from 'react'
import './InputForm.css'

const InputForm = () => {
    const [city, setCity] = useState('');
    const [weather, setWeather] = useState(null);

    const fetchWeather = async () => {
        try {
            const response = await fetch(`http://localhost:8000/weather?city=${city}`);
            const data = await response.json();
            setWeather(city);
        } catch (error) {
            console.error('Error fetching weather data:', error);
        }
    }

    return (
        <div className='InputForm'>
            <input
                className='weather-input'
                type='text'
                value={city}
                onChange={(e) => setCity(e.target.value)}
                placeholder='Enter city name'
            />
            <button className='weather-input-button' onClick={fetchWeather}>Get Weather</button>
        </div>
    )
}

export default InputForm