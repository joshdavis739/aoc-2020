using System.Collections.Generic;
using System.Linq;

namespace Day_10
{
    public class Graph
    {
        private TribCalculator _tribCalc { get; set; }

        public Graph(TribCalculator tribCalc)
        {
            _tribCalc = tribCalc;
            Vertices = new List<int>();
        }
        public IEnumerable<int> Vertices { get; set; }

        public int GetCountOfRoutesThrough()
        {
            return _tribCalc.Trib(Vertices.Count() - 1);
        }
    }
}
