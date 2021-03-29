using System;

namespace DepthFirstSearch
{
    public class Program
    {
        public class Node
        {
            public int key;
            public Node left;
            public Node right;

            public Node(int item)
            {
                key = item;
                left = right = null;
            }
        }
        public class BinaryTree
        {
            // root of Binary Tree
            public Node root;

            public BinaryTree()
            {
                root = null;
            }
            void PrintInOrder(Node node)
            {
                if (node == null)
                {
                    return;
                }
                // Recursive Call on Left Child
                PrintInOrder(node.left);

                // Print the current node
                Console.Write(node.key + ",");

                // Recursive call to Right Child
                PrintInOrder(node.right);

            }
            public void PrintInOrder()
            {
                PrintInOrder(root);
            }
        }
        public static void Main(string[] args)
        {
            BinaryTree Tree1 = new BinaryTree();
            // Create test values
            Tree1.root = new Node(1);
            Tree1.root.left = new Node(2);
            Tree1.root.right = new Node(3);
            Tree1.root.left.left = new Node(4);
            Tree1.root.left.right = new Node(5);

            // InOrder Prompt
            Console.WriteLine("Here is the Tree in Traversal Pattern: 'InOrder'");
            Tree1.PrintInOrder();
        }
    }
}
/*
Depth first search - search deep first before going to the next branch
Breadth First Search - search level by level

whenever we are at a given node, we are going to add that name to the array
- every child of the node, we are going to call the DFS function and pass in final array

Note - 3x different types of 'orders'
1. Inorder(left, root, right)
2. Preorder (root, left, right)
3. PostOrder (left right root)
*/