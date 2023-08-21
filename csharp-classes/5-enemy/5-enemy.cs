using System;

namespace Enemies
{
    /// <summary>
    /// This class represents a Zombie type enemy.
    /// </summary>
    public class Zombie
    {

        private int health;
        private string name = "(No name)";

        /// <summary>Initializes a new instance of the Zombie class.</summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Initializes a new instance of the Zombie class with an exception.
        /// </summary>
        public Zombie(int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            else
            {
                health = value;
            }
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name value.</value>
        public string Name { get { return name; } set { name = value; } }
        /// <summary>
        /// Gets the health value of the Zombie.
        /// </summary>
        /// <returns>The health value.</returns>
        public int GetHealth()
        {
            return health;
        }
        
        /// <summary>
        /// Prints the Zombie object’s attributes to stdout.
        /// </summary>
        /// <returns>A string representation of the Zombie object.</returns>
        public override string ToString()
        {
            return "Zombie Name: " + name + " / " + "Total Health: "  + health;
        }
    }
}

