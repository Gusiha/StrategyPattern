namespace StrategyPattern1
{
    internal class QuickSort : ISortAlgorithm
    {
        public IList<double> Sort(IList<double> values)
        {
            int startIndex = 0;
            int endIndex = values.Count - 1;
            QuickSortAlgorithm(values, startIndex, endIndex);
            return values;
        }

        private IList<double> QuickSortAlgorithm(IList<double> array, int startIndex, int finishIndex)
        {
            if (startIndex >= finishIndex)
            {
                return array;
            }

            int pivotIndex = GetPivotIndex(array, startIndex, finishIndex);

            // рекурсия с левым и правым подмассивами
            QuickSortAlgorithm(array, startIndex, pivotIndex - 1);
            QuickSortAlgorithm(array, pivotIndex + 1, finishIndex);

            return array;
        }

        private int GetPivotIndex(IList<double> array, int startIndex, int finishIndex)
        {
            int pivot = startIndex - 1;
            double temp;

            for (int i = startIndex; i <= finishIndex; i++)
            {
                if (array[i] < array[finishIndex])
                {
                    pivot++;
                    temp = array[pivot];
                    array[pivot] = array[i];
                    array[i] = temp;
                }
            }

            // перестановка опорного элемента(pivot)
            pivot++;

            temp = array[pivot];
            array[pivot] = array[finishIndex];
            array[finishIndex] = temp;

            return pivot;
        }
    }
}
