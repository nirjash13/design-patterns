using DesignPatterns.Singleton;
using System;

namespace Design_Patterns
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Testing the world of Singletons!");

      //Get object instance for the first time.
      var object1 = SingletonObject.Instance();
      Console.WriteLine($"Instance count: {object1.GetInstanceCount()}");

      //Get object instance for the second time.
      var object2 = SingletonObject.Instance();
      Console.WriteLine($"Instance count: {object2.GetInstanceCount()}");

      Console.ReadKey();
    }
  }
}
