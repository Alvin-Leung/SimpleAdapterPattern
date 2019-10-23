using System;

namespace AdapterPattern
{
    public class RoundPegAdapter : IRoundPeg
    {
        private readonly SquarePeg squarePeg;

        public double Radius => squarePeg.Width / Math.Sqrt(2);

        public RoundPegAdapter(SquarePeg squarePeg)
        {
            this.squarePeg = squarePeg;
        }
    }
}
