using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern1
{
    internal class BubbleSort : ISortAlgorithm
    {
        public IList<double> Sort(IList<double> values)
        {
            double temp;
            for (int i = 0; i < values.Count - 1; i++)
            {
                for (int j = 0; j < values.Count - i - 1; j++)
                {
                    if (values[j] > values[j + 1])
                    {
                        temp = values[j + 1];
                        values[j + 1] = values[j];
                        values[j] = temp;
                    }
                }

            }
            return values;
        }
    }
}
