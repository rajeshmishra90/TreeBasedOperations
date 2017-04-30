using System;
using System.Collections;
using System.Collections.Generic;

namespace TreeBasedProblems
{
    public class BstNode
    {
        public int Data { get; set; }

        public BstNode Left { get; set; }

        public BstNode Right { get; set; }
    }

    public class BSTOperations
    {
        public static BstNode root { get; set; }

        public BstNode Insert(BstNode root, int data)
        {
            if (root == null)
            {
                BstNode newNode = GetNewNode(data);
                root = newNode;
            }
            else
            {
                if (data < root.Data)
                {
                    var left = Insert(root.Left, data);
                    root.Left = left;
                }
                else
                {
                    var right = Insert(root.Right, data);
                    root.Right = right;
                }
            }
            return root;
        }

        public void Insert(int data)
        {
            if (root == null)
            {
                BstNode newNode = GetNewNode(data);
                root = newNode;
            }
            else
            {
                if (data < root.Data)
                {
                    var left = Insert(root.Left, data);
                    root.Left = left;
                }
                else
                {
                    var right = Insert(root.Right, data);
                    root.Right = right;
                }
            }
        }

        public static void TraverseTreeDFS(BstNode tree)
        {
            if (tree != null)
            {
                var data = tree.Data;
                TraverseTreeDFS(tree.Left);
                Console.Write(tree.Data + " ");
                TraverseTreeDFS(tree.Right);
            }
        }

        public static void TraverseBFS(BstNode tree)
        {
            Console.Write("BFS: ");
            Queue<BstNode> discoveredNodes = new Queue<BstNode>();
            discoveredNodes.Enqueue(tree);
            while (discoveredNodes.Count > 0)
            {
                var node = discoveredNodes.Dequeue();
                Console.Write(node.Data + " ");
                if (node.Left != null)
                {
                    discoveredNodes.Enqueue(node.Left);
                }
                if (node.Right != null)
                {
                    discoveredNodes.Enqueue(node.Right);
                }
            }
            Console.WriteLine();
        }

        public static int FindMin(BstNode root, int data)
        {
            if (root == null)
            {
                //Console.WriteLine("Item not found");
                return -1;
            }
            else if (root.Data == data)
            {
                return root.Data;
            }
            else
            {
                if (root.Data > data)
                {
                    return FindMin(root.Left, data);
                }
                else
                {
                    return FindMin(root.Right, data);
                }
            }
        }

        private static BstNode GetNewNode(int data)
        {
            BstNode newNode = new BstNode();
            newNode.Data = data;
            return newNode;
        }
    }
}