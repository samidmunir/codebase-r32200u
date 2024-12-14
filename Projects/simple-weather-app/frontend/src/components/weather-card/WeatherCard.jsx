import { WiBarometer, WiStrongWind, WiWindDeg, WiEarthquake } from 'react-icons/wi'
import WeatherIcon from '../../ui/weather-icon/WeatherIcon'
import './WeatherCard.css'

const WeatherCard = ({weather}) => {
    return (
        <div className='WeatherCard'>
            <div className='weather-location'>
                <span>{weather.localtime}</span>
                <h1>{weather.location}</h1>
                <h3>{weather.country}</h3>
            </div>
            <div className='weather-main'>
                <div className='weather-main-left'>
                    <p>{weather.observation_time}</p>
                    <h2>{weather.temperature}°C</h2>
                    <h4>Feels like {weather.feelslike}°C</h4>
                    <h3>{weather.description}</h3>
                </div>
                <div className='weather-main-right'>
                    <ul>
                        <li><WeatherIcon label='WND SPD' value={`${weather.wind_speed} MPH`} icon={<WiEarthquake />} /></li>
                        <li><WeatherIcon label='WND DEG' value={`${weather.wind_degree}°`} icon={<WiWindDeg />} /></li>
                        <li><WeatherIcon label='WND DIR' value={weather.wind_dir} icon={<WiStrongWind />} /></li>
                        <li><WeatherIcon label='PRESS' value={weather.pressure} icon={<WiBarometer />} /></li>
                    </ul>
                </div>
            </div>
        </div>
    )
}

export default WeatherCard