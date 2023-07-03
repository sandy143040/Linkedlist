﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please select any one program from below options\n");
                Console.WriteLine("1.Built-in LinkedlistDemo");
                Console.WriteLine("2.stack_Demo");
                Console.WriteLine("3.CustomLinked list");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        LinkedlistDemo list = new LinkedlistDemo();
                        list.Demo();
                        break;
                    case 2:
                        Console.WriteLine("--------------------");
                        Stack_Demo stack = new Stack_Demo();
                        stack.Element();
                        break;
                    case 3:
                        CustomLinkedlist customLinkedlist = new CustomLinkedlist();
                        customLinkedlist.Add(4);
                        customLinkedlist.Add(50);
                        customLinkedlist.Add(32);
                        break;
                    default:
                        Console.WriteLine("Enter valid input");
                        break;
                }

                Console.ReadLine();
            }
            
        }
    }
}