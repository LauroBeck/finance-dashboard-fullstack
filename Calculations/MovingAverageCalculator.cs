using System;
using System.Collections.Generic;
using System.Linq;

namespace JPMorgan.Calculations;

public class MovingAverageCalculator
{
    public double Calculate(List<double> prices)
    {
        if (prices.Count == 0) return 0;
        return prices.Average();
    }
}
