using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    internal class Program
    {
        public static List<int> base2 = new List<int>();

        private static void Main()
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }

        public static Node insert(Node head, int data)
        {
            if (head == null)
            {
                return new Node(data);
            }
            if (head.next == null)
            {
                head.next = new Node(data);
            }
            else
            {
                insert(head.next, data);
            }
            return head;

        }

        internal class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }

        }
        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
    }
}