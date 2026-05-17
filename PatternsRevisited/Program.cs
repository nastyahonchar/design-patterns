using PatternsRevisited.factory_method;
using PatternsRevisited.decorator;
using PatternsRevisited.strategy;
using PatternsRevisited.execute_around;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethodRunner.Run();
            DecoratorRunner.Run();
            StrategyRunner.Run();
            ExecuteAroundRunner.Run();
        }
    }
}
