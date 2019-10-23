using System;

namespace AdapterPattern
{
    /// <summary>
    /// An adapter that helps fit a <see cref="SquarePeg"/> into a <see cref="RoundHole"/>.
    /// </summary>
    public class RoundPegAdapter : IRoundPeg
    {
        private readonly SquarePeg squarePeg;

        /// <summary>
        /// The radius that the adapter would have to perfectly fit the square peg inside it.
        /// </summary>
        public double Radius => squarePeg.Width / Math.Sqrt(2);

        /// <summary>
        /// Constructs the <see cref="RoundPegAdapter"/> with a <see cref="SquarePeg"/>.
        /// </summary>
        public RoundPegAdapter(SquarePeg squarePeg)
        {
            this.squarePeg = squarePeg;
        }
    }
}
