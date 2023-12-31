﻿using System;
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
            if (temp == null)
            {
                Console.WriteLine("Linkedlist is Empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + "->");
                temp = temp.next;
            }
            Console.WriteLine("null");
        }
        public void ReverseOrder(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                //Node temp = head;
                //head = node;
                //head.next = temp;
                newNode.next = head;
                head = newNode;
            }
        }
        public void RemoveFirst()
        {
            if(head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            head=head.next;
            Console.WriteLine("First element Deleted successfully");
        }
        public void RemoveLast()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            if(head.next == null)
            {
                Console.WriteLine("single element is present");
            }
            else
            {
                Node temp = head;
                while(temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;
                Console.WriteLine("Deleted last Node");
            }
        }
        public void Size()
        {
            if(head ==null)
            {
                Console.WriteLine("Linkedlist is empty");
            }
            Node temp = head;
            int count = 1;
            while (temp.next != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine("size of linkedlist is " +count);
        }
        public int Search(int value)
        {
            Node node = head;
            if(node == null)
            {
                return -1;
            }
            int count = 0;
            while (node != null)
            {
                if(node.data == value)
                {
                    return count;
                }
                node = node.next;
                count++;
            }
            return count; 
        }
        public void AddMiddle(int idx, int data)
        {
            Node newNode = new Node(data);
            Node temp = head;
            int index = 0;
            while(index < idx - 1)
            {
                temp = temp.next;
                index++;
            }
            //index = idx-1; temp->prev
            newNode.next = temp.next;
            temp.next = newNode;
        }
        public void ReverseLinkedlist()
        {
            Node prev = null;            
            Node curr = head;
            Node next;
            while(curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            head = prev;
        }
    }
}
