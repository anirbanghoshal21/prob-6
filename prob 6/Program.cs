using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack(2);
            s.Push("Cricket");
            s.Push("Football");
            s.Push("Hockey");
            Console.WriteLine("count of stack" + s.Count);
            Console.WriteLine("element at the top is : " + s.Peek());
            object s1 = s.Pop();
            Console.WriteLine("1st pop:" + s1);
            Console.ReadLine();

        }
    }
}
