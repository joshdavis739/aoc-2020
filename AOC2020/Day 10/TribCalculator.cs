using System;
using System.Collections.Generic;
using System.Text;

namespace Day_10
{
    public class TribCalculator
    {
        private Dictionary<int, int> _tribCache = new Dictionary<int, int>
        {
            { 0, 1 },
            { 1, 1 },
            { 2, 2 },
            { 3, 4 }
        };

        public int Trib(int n)
        {
            if (_tribCache.TryGetValue(n, out var value))
            {
                return value;
            }

            for (var i = 4; i < n; i++)
            {
                if (!_tribCache.TryGetValue(i, out var _))
                {
                    _tribCache.Add(i, Trib(i));
                }
            }

            return Trib(n - 1) + Trib(n - 2) + Trib(n - 3);
        }
    }
}
