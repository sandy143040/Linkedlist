using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Demo
{
    public class LinkedlistDemo
    {
        //Linkedlist is a linear data structure which stores the element in the non-contiguous location.
        //The node had element are linked with each other using pointer
        //Linkedlist class allows insertion and deletion of element from a list very fastly.
        //Node-Node will be your Exact value
       //Next-reference of the next node
        public void Demo()
        {
            LinkedList<int> demo = new LinkedList<int>();
            demo.AddLast(3);
            demo.AddLast(5);
            demo.AddLast(6);
            demo.AddLast(7);
            demo.AddFirst(4);
            demo.AddFirst(9);
            foreach(int val in demo)
            {
                Console.WriteLine("Elements is: " +val);
            }
            Console.WriteLine("Remove a element from list " + demo.Remove(5));
            foreach (int val in demo)
            {
                Console.WriteLine("Elements in list are: " + val);
            }
            Console.WriteLine("Remove element from list");
            demo.Remove(demo.First);
            foreach (int val in demo)
            {
                Console.WriteLine("Elements in list are: " + val);
            }
            Console.WriteLine("Count is " + demo.Count);
            Console.WriteLine("Remove element from list");
            demo.Remove(demo.Last);
            foreach (int val in demo)
            {
                Console.WriteLine("Elements in list are: " + val);
            }
            demo.Clear();
            foreach (int val in demo)
            {
                Console.WriteLine("Deleted elements from list: " +val);
            }
            Console.WriteLine("count is "+demo.Count);
            if(demo.Contains(3) == true)
            {
                Console.WriteLine("the element was present");
            }
            else
            {
                Console.WriteLine("Element not fount");
            }
        }
    }
}
