using System;

namespace AdapterPattern
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            var squarePeg = new SquarePeg(width: 5.0);
            var roundPegAdapter = new RoundPegAdapter(squarePeg);
            var actualRoundPeg = new ActualRoundPeg(radius: 2);

            var roundHole = new RoundHole(roundPegAdapter.Radius);

            roundHole.Insert(actualRoundPeg);
            roundHole.Insert(roundPegAdapter);

            Console.ReadLine();
        }
    }
}
