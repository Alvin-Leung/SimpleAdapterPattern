using System;

namespace AdapterPattern
{
    /// <summary>
    /// This is the round hole we want to fit <see cref="SquarePeg"/> instances into.
    /// </summary>
    public class RoundHole
    {
        /// <summary>
        /// The radius of the hole.
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Creates a round hole with the specified <paramref name="radius"/>.
        /// </summary>
        public RoundHole(double radius)
        {
            this.Radius = radius;
        }

        /// <summary>
        /// Inserts any <see cref="IRoundPeg"/> implementation into the hole.
        /// </summary>
        public void Insert(IRoundPeg peg)
        {
            if (peg.Radius > this.Radius)
            {
                throw new Exception(message: "You cannot insert an object with larger radius than the hole!");
            }

            Console.WriteLine($"You have inserted a peg with radius {peg.Radius} into the hole successfully.");
        }
    }
}
