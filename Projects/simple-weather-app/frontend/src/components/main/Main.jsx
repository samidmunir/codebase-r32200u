import './Main.css'
import InputForm from '../input-form/InputForm'
import WeatherCard from '../weather-card/WeatherCard'

const Main = () => {
    return (
        <div className='Main'>
            <InputForm />
            <WeatherCard />
        </div>
    )
}

export default Main