"""
    Entry point for the backend.
"""

from fastapi import FastAPI
from app.routes import router

app = FastAPI()

# Register routes
app.include_router(router = router)

@app.get('/')
async def root():
    return {'message': 'Welcome to Simple Weather App API'}