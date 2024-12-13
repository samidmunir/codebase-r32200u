"""
    Handle all API routes.
"""

from fastapi import APIRouter, HTTPException
from app.services import fetch_weather_data

router = APIRouter()

@router.get('/weather')
async def get_weather(city: str):
    try:
        data = fetch_weather_data(city)
        return data
    except Exception as e:
        raise HTTPException(status_code = 500, detail = str(e))