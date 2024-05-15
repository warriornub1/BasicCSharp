using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DataStructures.LinkedList
{
    internal class LinkedList
    {
        private Node head;
        private Node tail;
        private int size;

        public LinkedList() 
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int length()
        {
            return size;
        }

        public bool isEmpty()
        {
            return size == 0;
        }

        public void addFirst(int e)
        {
            Node newest = new Node(e, null);
            if (isEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                newest.next = head;
                head = newest;
            }
            size++;
        }

        public void addLast(int e)
        {
            Node newest = new Node(e, null);
            if(isEmpty())
                head = newest;
            else
                tail.next = newest;
            tail = newest;
            size++;
        }

        public void addAny(int e, int position)
        {
            if(position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid Position");
                return;
            }
            Node newest = new Node(e, null);
            Node p = head;
            int i = 1;
            while (i < position - 1)
            {
                p = p.next;
                i++;
            }
            newest.next = p.next;
            p.next = newest;
            size++;
        }
        public void display()
        {
            Node p = head;
            Console.WriteLine("Printing all linked list");
            while (p != null)
            {
                Console.Write(p.num + " --> ");
                p = p.next;
            }
            Console.WriteLine();
        }
    }

    public class Node
    {
        public int num;
        public Node next;
        public Node(int num, Node next) 
        {
            this.num = num;
            this.next = next;
        }
    }
}
