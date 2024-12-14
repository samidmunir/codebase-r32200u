from supabase import Client
from app.schemas import ListingCreate

def create_listing(supabase: Client, listing: ListingCreate, owner_id: str):
    response = supabase.table('listings').insert({
        'title': listing.title,
        'description': listing.description,
        'price': listing.price,
        'owner_id': owner_id
    }).execute()

    return response.data

def get_listings(supabase: Client, skip: int = 0, limit: int = 10):
    response = supabase.table('listings').select('*').range(skip, skip + limit - 1).execute()

    return response.data