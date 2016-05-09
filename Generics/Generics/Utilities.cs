using System;

namespace Generics
{
    public class Utilities<T> where T : IComparable, new()
    {
        /*Other types of constraints are:
         * Where T : IComparable
         * Where T : Product
         * Where T : struct
         * Where T : class
         * Where T : new()
         */

        //Regular method to return max value
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        //Generic method to return max value with constraints
        //Without the 'where T : IComparable' the application does
        //not know what the type of a and b is

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }
    }
}