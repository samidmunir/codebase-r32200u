from supabase import Client
from app.schemas import UserCreate

def create_user(supabase: Client, user: UserCreate):
    response = supabase.table('users').insert({
        'username': user.username,
        'email': user.email,
        'hashed_password': user.password
    }).execute()

    return response.data

def get_user_by_email(supabase: Client, email: str):
    response = supabase.table('users').select('*').eq('email', email).single().execute()

    return response.data