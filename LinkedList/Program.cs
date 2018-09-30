using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetLinkedListOperations();
            //GetStackItems();
            //PostfixCalculator();
        }

        private static void PostfixCalculator()
        {
            string str = "567*+1-";
            Stack<int> postfixCal = new Stack<int>();
            foreach (var value in str)
            {
                var item = value.ToString();
                if (int.TryParse(item, out int res))
                    postfixCal.Push(res);
                else
                {
                    var var1 = postfixCal.Pop();
                    var var2 = postfixCal.Pop();
                    if (item == "+")
                        postfixCal.Push(var1 + var2);
                    else if (item == "-")
                        postfixCal.Push(var2 - var1);
                    else if (item == "*")
                        postfixCal.Push(var1 * var2);
                    else if (item == "/")
                        postfixCal.Push(var2 / var1);
                }
            }
            if (postfixCal.Count() != 1)
                Console.WriteLine("Input was wrong");
            else
                Console.WriteLine(postfixCal.Pop());
        }

        private static void GetStackItems()
        {
            var stk = new Stack<int>();
            stk.Push(5);
            stk.Push(10);
            stk.Push(15);
            stk.Push(20);
            Console.WriteLine(stk.ToString());


            stk.Pop();
            Console.WriteLine("After Pop");
            Console.WriteLine(stk.ToString());

            stk.Pop();
            Console.WriteLine("After Pop");
            Console.WriteLine(stk.ToString());
        }

        private static void GetLinkedListOperations()
        {
            var lst = new LinkedList<int>();
            lst.Add(5);
            lst.Add(4);
            lst.Add(3);
            lst.Add(2);
            lst.Add(1);

            lst.ToString();
            
            lst.RemoveFirst();
            Console.WriteLine("\n= After removing first Node =");
            lst.ToString();

            lst.RemoveLast();
            Console.WriteLine("\n= After removing last node =");
            lst.ToString();

            lst.Remove(3);
            Console.WriteLine("\n= Removed Node has value 3 =");
            lst.ToString();
        }
    }
}
