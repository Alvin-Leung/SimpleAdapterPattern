using System;

namespace AdapterPattern
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            var squarePeg = new SquarePeg(width: 5.0); // First we create a square peg
            var roundPegAdapter = new RoundPegAdapter(squarePeg); // Then we wrap the square peg with an adapter
            var actualRoundPeg = new ActualRoundPeg(radius: 2); // Here we've created a round peg just for kicks

            var roundHole = new RoundHole(roundPegAdapter.Radius); // We construct the round hole such that it will perfectly fit the roundPegAdapter

            roundHole.Insert(actualRoundPeg); // Of course we can insert an actual round peg
            roundHole.Insert(roundPegAdapter); // And with the adapter pattern, we can insert a square peg too, as long as we wrap it with the adapter first

            Console.ReadLine();
        }
    }
}
