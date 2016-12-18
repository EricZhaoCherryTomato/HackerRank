using System;
using System.Threading;

namespace HackerRank
{
    internal class Program
    {
        private static void Main()
        {
            Node root = null;
            var T = int.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                var data = int.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            var height = getHeight(root);
            Console.WriteLine(height);
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

        private static int getHeight(Node root)
        {
            int leftHeight = 0;
            int rightHeight = 0;

            if (root.left != null)
            {
                leftHeight = getHeight(root.left) + 1;
            }
            if (root.right != null)
            {
                rightHeight = getHeight(root.right) + 1;
            }
            return leftHeight > rightHeight ? leftHeight : rightHeight;
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