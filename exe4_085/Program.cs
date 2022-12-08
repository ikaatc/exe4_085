using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe4_085
{
    class Stack
    {
        public string[] arr;
        public int top;
        public int max;

        public Stack()
        {
            arr = new string[104];
            top = -1;
            max = arr.Length;
        }
        public int pop()
        {
            if (top == -1)
            {
                Console.WriteLine("\nStack Empty");
                return -1;
            }
            else
            {
                Console.WriteLine("Popped Element is: ");
                top--;
                return top;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
