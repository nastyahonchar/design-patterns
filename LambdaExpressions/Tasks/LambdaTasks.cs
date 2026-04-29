using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions.Tasks
{
    public static class LambdaTasks
    {
        public static List<int> FilterOdd(List<int> numbers)
            => numbers.Where(x => x % 2 != 0).ToList();

        public static double Average(List<double> numbers)
            => numbers.Aggregate(0.0, (acc, x) => acc + x) / numbers.Count;

        public static List<string> SortAlphabetical(List<string> list)
            => list.OrderBy(x => x).ToList();

        public static int SumEven(List<int> numbers)
            => numbers.Where(x => x % 2 == 0).Sum();

        public static long Factorial(int n)
            => Enumerable.Range(1, n).Aggregate(1L, (acc, x) => acc * x);

        public static (int Sum, int Product) SumAndProduct(List<int> numbers)
            => (
                numbers.Aggregate(0, (acc, x) => acc + x),
                numbers.Aggregate(1, (acc, x) => acc * x)
            );

        public static List<int> Squares(List<int> numbers)
            => numbers.Select(x => x * x).ToList();

        public static List<string> SortByLength(List<string> list)
            => list.OrderBy(x => x.Length).ToList();

        public static int CountWords(string sentence)
            => sentence.Split(' ').Count(x => !string.IsNullOrWhiteSpace(x));

        public static string FirstNonEmpty(List<string> list)
            => list.FirstOrDefault(x => !string.IsNullOrWhiteSpace(x)) ?? "";

        public static bool AllStartWithUppercase(List<string> list)
            => list.All(x => !string.IsNullOrEmpty(x) && char.IsUpper(x[0]));

        public static int SecondLargest(List<int> numbers)
            => numbers.Distinct().OrderByDescending(x => x).Skip(1).First();

        public static int MaxEven(List<int> numbers)
            => numbers.Where(x => x % 2 == 0).Max();
    }
}
