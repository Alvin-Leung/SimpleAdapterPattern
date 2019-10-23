namespace AdapterPattern
{
    public class ActualRoundPeg : IRoundPeg
    {
        public double Radius { get; }

        public ActualRoundPeg(double radius)
        {
            this.Radius = radius;
        }
    }
}
