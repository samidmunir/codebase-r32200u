import './WeatherCard.css'

const WeatherCard = (weather) => {
    return (
        <div className='WeatherCard'>
            <div className='weather-location'>
                <h1>City</h1>
                <p>Local Time</p>
                <h3>Region, Country</h3>
            </div>
            <div className='weather-main'>
                <div className='weather-main-left'>
                    <p>Observation Time</p>
                    <h2>Temperature</h2>
                    <h3>Description</h3>
                    <h4>Feels Like: 9</h4>
                </div>
                <div className='weather-main-right'>
                    <ul>
                        <li>Wind Speed</li>
                        <li>Wind Deg</li>
                        <li>Wind Dir</li>
                        <li>Pressure</li>
                    </ul>
                </div>
            </div>
        </div>
    )
}

export default WeatherCard