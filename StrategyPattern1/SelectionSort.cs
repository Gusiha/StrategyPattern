using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern1
{
    internal class SelectionSort : ISortAlgorithm
    {
        public IList<double> Sort(IList<double> values)
        {
            int min;                                                            //var used for minimal element

            for (int i = 0; i < values.Count; i++)
            {
                min = i;
                for (int j = i + 1; j < values.Count; j++)                              //it's value now being compared to the other elements in order to determine the smallest one
                {
                    if (values[min] > values[j])
                        min = j;                                                //in case of a match, the minimal element is changed
                }
                double temp = values[i];                                              //swapping occures by the end of cycle iteration that puts smaller elements to the beginning
                values[i] = values[min];
                values[min] = temp;
            }

            return values;
        }
    }
}
