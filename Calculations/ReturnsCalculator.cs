using System;
using System.Collections.Generic;

namespace JPMorgan.Calculations;

public class ReturnsCalculator
{
    public List<double> SimpleReturns(List<double> prices)
    {
        if (prices == null || prices.Count < 2)
            throw new ArgumentException("At least 2 prices required");

        var returns = new List<double>();

        for (int i = 1; i < prices.Count; i++)
        {
            double r = (prices[i] - prices[i - 1]) / prices[i - 1];
            returns.Add(r);
        }

        return returns;
    }
}
