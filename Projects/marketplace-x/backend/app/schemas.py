from pydantic import (BaseModel, EmailStr)

# User schemas
class UserBase(BaseModel):
    username: str
    email: EmailStr

class UserCreate(UserBase):
    password: str

class UserOut(UserBase):
    id: str

# Listings schemas
class ListingBase(BaseModel):
    title: str
    description: str
    price: float

class ListingCreate(ListingBase):
    pass

class ListingOut(ListingBase):
    id: int
    owner_id: str