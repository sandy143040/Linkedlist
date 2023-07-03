using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Demo
{
    public class Stack_Demo
    {
        public void Element()
        {
            Stack stack = new Stack();
            stack.Push("Sandeep");
            stack.Push("singh");
            stack.Push(30);
            stack.Push('S');
            foreach (var item in stack)
            {
                Console.WriteLine("Elements in stack: " +item);
            }
            Console.WriteLine("count is: " + stack.Count);
            Console.WriteLine(stack.Contains(30));
            Console.WriteLine(stack.Peek());
            foreach (var item in stack)
            {
                Console.WriteLine("Elements in stack: " + item);
            }
            Console.WriteLine("Remove the top element: " +stack.Pop());
            foreach (var item in stack)
            {
                
                Console.WriteLine("Element in stack after removing top elem: "+ item);
            }
        }
    }
}
