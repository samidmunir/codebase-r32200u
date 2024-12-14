import {useState} from 'react';
import './Main.css'
import InputForm from '../input-form/InputForm'
import WeatherCard from '../weather-card/WeatherCard'

const Main = () => {
    const [city, setCity] = useState('');
    const [weather, setWeather] = useState(null);

    function handleSetCity(new_city) {
        setCity(new_city);
    }

    const handleFetchWeather = async () => {
        try {
            const response = await fetch(`http://localhost:8000/weather?city=${city}`);
            const data = await response.json();
            setWeather(data);
        } catch (error) {
            console.error('Error fetching weather data:', error);
        }
    }

    return (
        <div className='Main'>
            <InputForm city={city} handleSetCity={handleSetCity} handleFetchWeather={handleFetchWeather} />
            {
                weather && (
                    <WeatherCard weather={weather} />
                )
            }
        </div>
    )
}

export default Main