"""
    Entry point for the backend.
"""

from fastapi import FastAPI
from fastapi.middleware.cors import CORSMiddleware
from app.routes import router

app = FastAPI()

# Add CORS Middleware
app.add_middleware(
    CORSMiddleware,
    allow_origins = ['*'],
    allow_credentials = True,
    allow_methods = ['*'],
    allow_headers = ['*']
)

# Register routes
app.include_router(router = router)

@app.get('/')
async def root():
    return {'message': 'Welcome to Simple Weather App API'}