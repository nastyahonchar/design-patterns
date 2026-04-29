using LambdaExpressions;
using LambdaExpressions.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        var doubles = new List<double> { 1.5, 2.5, 3.5, 4.5 };
        var strings = new List<string> { "fantasy", "horror", "detective", "science" };

        Console.WriteLine("1) Odd numbers:");
        Console.WriteLine(string.Join(", ", LambdaTasks.FilterOdd(ints)));

        Console.WriteLine("\n2) Average:");
        Console.WriteLine(LambdaTasks.Average(doubles));

        Console.WriteLine("\n3) Sorted strings:");
        Console.WriteLine(string.Join(", ", LambdaTasks.SortAlphabetical(strings)));

        Console.WriteLine("\n4) Sum of even numbers:");
        Console.WriteLine(LambdaTasks.SumEven(ints));

        Console.WriteLine("\n5) Factorial (5):");
        Console.WriteLine(LambdaTasks.Factorial(5));

        Console.WriteLine("\n6) Product & Sum:");
        Console.WriteLine($"Sum: {LambdaTasks.Sum(ints)}, Product: {LambdaTasks.Product(ints)}");

        Console.WriteLine("\n7) Squares:");
        Console.WriteLine(string.Join(", ", LambdaTasks.Squares(ints)));

        Console.WriteLine("\n8) Sort by length:");
        Console.WriteLine(string.Join(", ", LambdaTasks.SortByLength(strings)));

        Console.WriteLine("\n9) Word count:");
        Console.WriteLine(LambdaTasks.CountWords("This is the fourth lab on design patterns."));

        Console.WriteLine("\n10) First non-empty:");
        var listWithEmpty = new List<string> { "", "  ", "hello", "world" };
        Console.WriteLine(LambdaTasks.FirstNonEmpty(listWithEmpty));

        Console.WriteLine("\n11) All start with uppercase:");
        var caps = new List<string> { "Fantasy", "Detective", "Horror" };
        Console.WriteLine(LambdaTasks.AllStartWithUppercase(caps));

        Console.WriteLine("\n12) Second largest:");
        Console.WriteLine(LambdaTasks.SecondLargest(ints));

        Console.WriteLine("\n13) Max even:");
        Console.WriteLine(LambdaTasks.MaxEven(ints));
    }
}