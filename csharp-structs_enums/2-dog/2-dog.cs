using System;

enum Rating
{
    Good,
    Great,
    Excellent
}

struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public Dog (string sName, float sAge, string sOwner, Rating sRating)
    {
        name = sName;
        age = sAge;
        owner = sOwner;
        rating = sRating;
    }
}
