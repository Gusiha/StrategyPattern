using System.Numerics;

namespace StrategyPattern1
{
    internal interface ISortAlgorithm
    {
        public IList<double> Sort(IList<double> values);
    }
}
