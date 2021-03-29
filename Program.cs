using System;

namespace DepthFirstSearch
{
    public class Program
    {
        public class Node
        {
            // Node Attributes
            public int key;
            public Node left;
            public Node right;

            // Node Constructor
            public Node(int item)
            {
                key = item;
                left = right = null;
            }
        }
        public class BinaryTree
        {
            // Attribute -  root of type Node
            public Node root;

            public BinaryTree()
            {
                root = null;
            }
            // Method to print node values InOrder Traversal
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
            // Method to print node values in "PreOrder" Traversal
            public void PrintPreOrder(Node node)
            {
                if (node == null)
                {
                    return;
                }
                Console.Write(node.key + ",");
                PrintPreOrder(node.left);
                PrintPreOrder(node.right);
            }
            public void PrintPreOrder()
            {
                PrintPreOrder(root);
            }
            // Method to print in PostOrder
            public void PrintPostOrder(Node node)
            {
                if (node == null)
                {
                    return;
                }
                PrintPostOrder(node.left);
                PrintPostOrder(node.right);
                Console.Write(node.key + ",");
            }
            public void PrintPostOrder()
            {
                PrintPostOrder(root);
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

            // InOrder Prompt - Should Return 4,2,5,1,3
            Console.WriteLine("Here is the Tree in Traversal Pattern: 'InOrder'");
            Tree1.PrintInOrder();
            Console.WriteLine("\n");

            // PreOrder Prompt - Should Return 1,2,4,5,3
            Console.WriteLine("Here is the Tree in Traversal Pattern: 'PreOrder'");
            Tree1.PrintPreOrder();
            Console.WriteLine("\n");

            // PostOrder Prompt - Should Return 4,5,2,3,1
            Console.WriteLine("Here is the Tree in Traversal Pattern: 'PostOrder'");
            Tree1.PrintPostOrder();
            Console.WriteLine("\n");
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