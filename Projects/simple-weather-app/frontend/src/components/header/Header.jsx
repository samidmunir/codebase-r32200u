import './Header.css'

const Header = ({currentTime}) => {
    return (
        <div className='Header'>
            <div className='Header-left'>
                <h1>Simple Weather App</h1>
            </div>
            <div className='Header-center'>
                <button className='Header-button'>Units</button>
                <button className='Header-button'>Reset</button>
                <button className='Header-button'>Option 1</button>
            </div>
            <div className='Header-right'>
                <h2>{currentTime}</h2>
            </div>
        </div>
    )
}

export default Header