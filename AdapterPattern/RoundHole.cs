using System;

namespace AdapterPattern
{
    public class RoundHole
    {
        public double Radius { get; }

        public RoundHole(double radius)
        {
            this.Radius = radius;
        }

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
