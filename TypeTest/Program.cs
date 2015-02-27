using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Extend2 extend2 = new Extend2();
            Base baseClass = extend2;

            Type type = baseClass.GetType();

            #region typeof
            if (type == typeof(object))
            {
                Console.WriteLine("typeof Object");
            }

            if (type == typeof(Extend2))
            {
                Console.WriteLine("typeof Extend2");
            }
            #endregion

            foreach (var interfaceType in type.GetInterfaces())
            {
                if (interfaceType == typeof(ITest))
                {
                    Console.WriteLine("typeof ITest");
                }

                if (interfaceType == typeof(ITest2))
                {
                    Console.WriteLine("typeof ITest2");
                }

            }

            #region is 
            if (type is object)
            {
                Console.WriteLine("is Object");
            }

            if (type is Extend2)
            {
                Console.WriteLine("is Extend2");
            }
            #endregion

        }
    }

    public interface ITest
    {
    }

    public interface ITest2
    {
    }

    public class Base : Object
    {
    }

    public class Extend : Base, ITest
    {
    }

    public class Extend2 : Base, ITest, ITest2
    {
    }

}
