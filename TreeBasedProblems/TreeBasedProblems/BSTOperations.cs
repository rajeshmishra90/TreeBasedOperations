using System;
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

        private BstNode Insert(BstNode root, int data)
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

        public static int FindItem(BstNode root, int data)
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
                    return FindItem(root.Left, data);
                }
                else
                {
                    return FindItem(root.Right, data);
                }
            }
        }

        public static BstNode FindMin(BstNode root)
        {
            if (root == null)
            {
                //Console.WriteLine("Item not found");
                return root;
            }
            else if (root.Left == null)
            {
                return root;
            }
            else
            {
                return FindMin(root.Left);
            }
        }

        public static BstNode FindMax(BstNode root)
        {
            if (root == null)
            {
                //Console.WriteLine("Item not found");
                return root;
            }
            else if (root.Right == null)
            {
                return root;
            }
            else
            {
                return FindMax(root.Right);
            }
        }

        public static int GetHeight(BstNode root)
        {
            int leftHeight = 0;
            int rightHeight = 0;
            if (root == null)
            {
                return -1;
            }

            leftHeight = GetHeight(root.Left);
            rightHeight = GetHeight(root.Right);
            int height = Math.Max(leftHeight, rightHeight) + 1;
            return height;
        }

        private static bool IsBstUtil(BstNode root, int minvalue, int maxvalue)
        {
            if (root == null)
                return true;
            if (root.Data > minvalue && root.Data < maxvalue
                && IsBstUtil(root.Left, minvalue, root.Data) && IsBstUtil(root.Right, root.Data, maxvalue))
            {
                return true;
            }
            else
                return false;
        }

        public static bool IsBinarySearchTree(BstNode root)
        {
            return IsBstUtil(root, int.MinValue, int.MaxValue);
        }

        //private bool IsSubtreeGreater(BstNode right, int data)
        //{
        //    if (right.Data >= data && IsSubtreeGreater(right.Right, data) && IsSubtreeLesser(right.Left, data))
        //    {
        //        return true;
        //    }
        //    else
        //        return false;
        //}

        //private bool IsSubtreeLesser(BstNode left, int data)
        //{
        //    if (left.Data <= data && IsSubtreeGreater(left.Right, data) && IsSubtreeLesser(left.Left, data))
        //    {
        //        return true;
        //    }
        //    else
        //        return false;
        //}

        public static BstNode Delete(BstNode root, int data)
        {
            if (root == null) return root;
            if (data < root.Data)
                root.Left = Delete(root.Left, data);
            else if (data > root.Data)
                root.Right = Delete(root.Right, data);
            else
            {
                if (root.Left == null && root.Right == null)
                {
                    root = null;
                }
                else if (root.Left == null)
                {
                    root = root.Right;
                }
                else if (root.Right == null)
                {
                    root = root.Left;
                }
                else
                {
                    var node = FindMin(root.Right);
                    root.Data = node.Data;
                    root.Right = Delete(root.Right, node.Data);
                }
            }
            return root;
        }

        private static BstNode GetNewNode(int data)
        {
            BstNode newNode = new BstNode();
            newNode.Data = data;
            return newNode;
        }
    }
}