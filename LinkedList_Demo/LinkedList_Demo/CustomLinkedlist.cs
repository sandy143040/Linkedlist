using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Demo
{
    public class CustomLinkedlist
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("Node is Added :" + node.data);
        }
        public void Display()
        {
            Node temp = head;
            if(temp==null)
            {
                Console.WriteLine("Linkedlist is Empty");
            }
            while(temp!=null)
            {
                Console.Write(temp.data+" ");
                temp = temp.next;
            }
        }
    }
}
