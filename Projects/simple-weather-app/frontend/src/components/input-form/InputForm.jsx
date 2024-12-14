import './InputForm.css'

const InputForm = ({city, handleSetCity, handleFetchWeather}) => {
    return (
        <div className='InputForm'>
            <input
                className='weather-input'
                type='text'
                value={city}
                onChange={(e) => handleSetCity(e.target.value)}
                placeholder='Enter city name'
            />
            <button className='weather-input-button' onClick={handleFetchWeather}>Get Weather</button>
        </div>
    )
}

export default InputForm