namespace AdapterPattern
{
    /// <summary>
    /// A good ol' square peg that does not seem to fit inside a <see cref="RoundHole"/>. What to do?
    /// </summary>
    public class SquarePeg
    {
        /// <summary>
        /// The width of all sides of the square.
        /// </summary>
        public double Width { get; }

        /// <summary>
        /// Constructs a square with the specified <paramref name="width"/>.
        /// </summary>
        public SquarePeg(double width)
        {
            this.Width = width;
        }
    }
}
