import './WeatherIcon.css'

const WeatherIcon = ({label, value, icon}) => {
    return (
        <div className='WeatherIcon'>
            <p className='WeatherIcon-value'>{value}</p>
            <p className='WeatherIcon-label'>{label}</p>
            <p className='WeatherIcon-icon'>{icon}</p>
        </div>
    )
}

export default WeatherIcon