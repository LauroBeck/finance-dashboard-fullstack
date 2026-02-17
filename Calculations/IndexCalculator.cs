using System;
using System.Collections.Generic;
using System.Linq;

namespace JPMorgan.Calculations;

public class IndexCalculator
{
    public double Calculate(List<double> prices)
    {
        return prices.Count == 0 ? 0 : prices[^1]; // last element
    }
}

