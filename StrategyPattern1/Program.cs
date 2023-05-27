using StrategyPattern1;

Context context = new();

List<double> results = new List<double>() { 2.4, 54, 54, 87, -2, 2, 67, 9.3, 9.2, 9.5 };

context.SetSortAlgorithm(new SelectionSort());
context.Sort(results);
context.Print(results);

results.Reverse();

context.SetSortAlgorithm(new BubbleSort());
context.Sort(results);
context.Print(results);

results.Reverse();

context.SetSortAlgorithm(new QuickSort());
context.Sort(results);
context.Print(results);
