using System;
using System.Globalization;

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
    public override string ToString()
    {
        string formattedAge = age.ToString("0.0", CultureInfo.InvariantCulture);
        return string.Format("Dog Name: {0}\nAge: {1}\nOwner: {2}\nRating: {3}", name, formattedAge, owner, rating);
    }
}

