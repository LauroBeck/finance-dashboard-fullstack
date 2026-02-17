using System;
using System.Collections.Generic;
using System.Linq;

namespace JPMorgan.Calculations;

public class VolatilityCalculator
{
    public double Calculate(List<double> prices)
    {
        if (prices.Count < 2) return 0;

        var avg = prices.Average();
        var variance = prices.Sum(p => Math.Pow(p - avg, 2)) / prices.Count;
        return Math.Sqrt(variance);
    }
}
