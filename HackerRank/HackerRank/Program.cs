using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace HackerRank
{
    internal class Program
    {
        private static void Main()
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            levelOrder(root);
        }

        private static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            Node cur;
            if (data <= root.data)
            {
                cur = insert(root.left, data);
                root.left = cur;
            }
            else
            {
                cur = insert(root.right, data);
                root.right = cur;
            }
            return root;
        }

        static void levelOrder(Node root)
        {
            //Write your code here
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            while (q.Any()) 
            {
                Node temp = q.Dequeue();
                Console.Write(temp.data + " ");

                if (temp.left != null)
                {
                    q.Enqueue(temp.left);
                }
                if (temp.right != null)
                {
                    q.Enqueue(temp.right);
                }
            }

        }
    }

    internal class Node
    {
        public Node left, right;
        public int data;

        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }
}