using JPMorgan.Calculations;

namespace JPMorgan.Services;

public class AnalyticsService
{
    private readonly IndexCalculator _index;
    private readonly ReturnsCalculator _returns;
    private readonly VolatilityCalculator _volatility;
    private readonly MovingAverageCalculator _ma;

    public AnalyticsService(
        IndexCalculator index,
        ReturnsCalculator returnsCalc,
        VolatilityCalculator volatility,
        MovingAverageCalculator ma)
    {
        _index = index;
        _returns = returnsCalc;
        _volatility = volatility;
        _ma = ma;
    }

    public object AnalyzeSeries(List<double> prices)
    {
        return new
        {
            Index = _index.Calculate(prices),
           Returns = _returns.SimpleReturns(prices),

            Volatility = _volatility.Calculate(prices),
            MovingAverage = _ma.Calculate(prices)
        };
    }
}
