import {useState} from 'react';

const Home = () => {
    const [city, setCity] = useState('');
    const [weather, setWeather] = useState(null);

    const fetchWeather = async () => {
        try {
            const response = await fetch(`http://localhost:8000/weather?city=${city}`);
            const data = await response.json();
            setWeather(data);
        } catch (error) {
            console.error('Error fetching weather data:', error);
        }
    };

    return (
        <div>
            <h1>Simple Weather App</h1>
            <input
                type='text'
                value={city}
                onChange={(e) => setCity(e.target.value)}
                placeholder='Enter city name'
            />
            <button onClick={fetchWeather}>Get Weather</button>
            {
                weather && (
                    <div>
                        <h2>{weather.location}</h2>
                        <p>Temperature: {weather.temperature}°C</p>
                        <p>Description: {weather.description}</p>
                    </div>
                )
            };
        </div>
    );
};

export default Home;