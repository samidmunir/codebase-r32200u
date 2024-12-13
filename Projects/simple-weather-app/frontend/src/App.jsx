import {useState, useEffect} from 'react'
import Header from './components/header/Header'
import Main from './components/main/Main'

const App = () => {
  const [currentTime, setCurrentTime] = useState(new Date().toLocaleTimeString());
  
  useEffect(() => {
    const timer = setInterval(() => {
      setCurrentTime(new Date().toLocaleTimeString());
    }, 1000)

    return () => clearInterval(timer);
  }, [])
  
  return (
    <>
      <Header currentTime={currentTime} />
      <Main />
    </>
  )
}

export default App