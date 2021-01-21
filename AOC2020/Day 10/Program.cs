using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_10
{
    class Program
    {

        static void Main()
        {
            var orderedInputs = Inputs.BigInput
                .Split("\r\n")
                .Select(x => int.Parse(x))
                .Append(0)
                .OrderBy(x => x);

            var inputs = orderedInputs
                .Append(orderedInputs.Last() + 3)
                .ToArray();

            var tribCalc = new TribCalculator();
            var subGraphs = new List<Graph>();
            var newGraph = new Graph(tribCalc);

            for (var i = 0; i < inputs.Length - 1; i++)
            {
                var diff = inputs[i + 1] - inputs[i];
                newGraph.Vertices = newGraph.Vertices.Append(inputs[i]);
                if (diff == 3)
                {
                    subGraphs.Add(newGraph);
                    newGraph = new Graph(tribCalc);
                }
            }

            newGraph.Vertices = newGraph.Vertices.Append(inputs.Last());
            subGraphs.Add(newGraph);

            var countsOfRoutesThrough = subGraphs
                .Select(x => x.GetCountOfRoutesThrough());

            long totalCount = 1;
            foreach (var count in countsOfRoutesThrough)
            {
                totalCount *= count;
            }

            Console.WriteLine(totalCount);
        }
    }
}
