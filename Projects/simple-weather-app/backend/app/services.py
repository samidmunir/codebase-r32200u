import requests
from app.settings import WEATHERSTACK_API_KEY

BASE_URL = 'http://api.weatherstack.com/current'

def fetch_weather_data(city: str) -> dict:
    params = {'access_key': WEATHERSTACK_API_KEY, 'query': city}
    response = requests.get(BASE_URL, params = params)

    if response.status_code != 200:
        raise Exception('Failed to fetch data from WeatherStack API')
    
    data = response.json()
    if 'error' in data:
        raise Exception(data['error']['info'])
    return {
        'location': data['location']['name'],
        'temperature': data['current']['temperature'],
        'description': data['current']['weather_descriptions'][0]
    }