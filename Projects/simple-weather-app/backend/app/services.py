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
        'country': data['location']['country'],
        'region': data['location']['region'],
        'latitude': data['location']['lat'],
        'longitude': data['location']['lon'],
        'timezone_id': data['location']['timezone_id'],
        'localtime': data['location']['localtime'],
        'utc_offset': data['location']['utc_offset'],
        'observation_time': data['current']['observation_time'],
        'temperature': data['current']['temperature'],
        'feelslike': data['current']['feelslike'],
        'description': data['current']['weather_descriptions'][0],
        'wind_speed': data['current']['wind_speed'],
        'wind_degree': data['current']['wind_degree'],
        'wind_dir': data['current']['wind_dir'],
        'pressure': data['current']['pressure'],
    }