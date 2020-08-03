using System.Runtime.CompilerServices;

namespace DesignPatterns.Singleton
{
  public class SingletonObject
  {
    private static readonly SingletonObject instance = new SingletonObject();
    private static readonly int instanceCount;
    static SingletonObject()
    {
      instanceCount += 1;
    }

    private SingletonObject()
    {

    }

    public static SingletonObject Instance()
    {
      return instance;
    }

    public int GetInstanceCount()
    {
      return instanceCount;
    }
  }
}
