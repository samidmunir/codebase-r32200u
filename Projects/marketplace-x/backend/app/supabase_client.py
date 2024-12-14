from supabase import (create_client, Client)

SUPABASE_URL = 'https://csirsqnqwlnlfyaypgqo.supabase.co'
SUPABASE_KEY = 'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImNzaXJzcW5xd2xubGZ5YXlwZ3FvIiwicm9sZSI6ImFub24iLCJpYXQiOjE3MzQxNzk4MDksImV4cCI6MjA0OTc1NTgwOX0.QsvFkrM6w4S_-pTuRFYrVl9ozNWhKO8Fn407vxASWYI'

def get_supabase_client() -> Client:
    supabase_client = create_client(SUPABASE_URL, SUPABASE_KEY)
    
    return supabase_client