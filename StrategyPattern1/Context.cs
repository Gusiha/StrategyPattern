namespace StrategyPattern1
{
    internal class Context
    {
        private ISortAlgorithm _sortAlgorithm;

        public void SetSortAlgorithm(ISortAlgorithm sortAlgorithm)
        {
            _sortAlgorithm = sortAlgorithm;
        }

        public List<double> Sort(List<double> doubles)
        {
            return _sortAlgorithm.Sort(doubles).ToList();
        }

        public void Print(List<double> doubles)
        {
            Console.WriteLine($"---{_sortAlgorithm.GetType().Name}---");
            foreach (var item in doubles)
            {
                Console.WriteLine(item);
            }
        }
    }
}
