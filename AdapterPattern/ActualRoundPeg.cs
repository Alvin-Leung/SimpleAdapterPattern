namespace AdapterPattern
{
    /// <summary>
    /// An actual round peg. This peg fits into a <see cref="RoundHole"/> just fine.
    /// </summary>
    public class ActualRoundPeg : IRoundPeg
    {
        /// <summary>
        /// The radius of the peg.
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Constructs an <see cref="ActualRoundPeg"/> with the given <paramref name="radius"/>.
        /// </summary>
        public ActualRoundPeg(double radius)
        {
            this.Radius = radius;
        }
    }
}
