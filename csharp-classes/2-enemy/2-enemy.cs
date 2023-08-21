using System;

namespace Enemies
{
    /// <summary>
    /// This class represents a Zombie type enemy.
    /// </summary>
    public class Zombie
    {

        public int health;

        /// <summary>Initializes a new instance of the Zombie class.</summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>Initializes a new instance of the Zombie class with an exception.</summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            else
            {
                health = value;
            }
        }
    }
}