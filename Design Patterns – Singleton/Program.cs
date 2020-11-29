using System;

namespace Design_Patterns___Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = SingletonDataContainer.Instance;
            Console.WriteLine(db.GetPopulation("Washington, D.C."));
            var db2 = SingletonDataContainer.Instance;
            Console.WriteLine(db2.GetPopulation("London"));
            var db3 = SingletonDataContainer.Instance;
            var db4 = SingletonDataContainer.Instance;
        }
    }
}
