namespace TreeBasedProblems
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BSTOperations operations = new BSTOperations();
            operations.Insert(15);
            operations.Insert(20);
            operations.Insert(10);
            operations.Insert(25);
            operations.Insert(17);
            operations.Insert(8);
            operations.Insert(12);
            operations.Insert(5);
            operations.Insert(30);
            operations.Insert(40);
            operations.Insert(55);
            operations.Insert(7);
            operations.Insert(28);
            operations.Insert(22);
            System.Console.Write("DFS: ");
            BSTOperations.TraverseTreeDFS(BSTOperations.root);
            System.Console.WriteLine();
            BSTOperations.TraverseBFS(BSTOperations.root);

            //Delete
            BSTOperations.Delete(BSTOperations.root, 20);

            System.Console.Write("DFS: ");
            BSTOperations.TraverseTreeDFS(BSTOperations.root);
            System.Console.WriteLine();
            BSTOperations.TraverseBFS(BSTOperations.root);

            System.Console.WriteLine("Height: " + BSTOperations.GetHeight(BSTOperations.root));
            int itemToFind = 25;
            var value = BSTOperations.FindItem(BSTOperations.root, itemToFind);
            if (value == -1)
            {
                System.Console.WriteLine("Item not found");
            }
            else
            {
                System.Console.WriteLine("Item Found");
            }
            BstNode min = BSTOperations.FindMin(BSTOperations.root);
            if (min != null)
            {
                System.Console.WriteLine("Min: " + min.Data);
            }
            BstNode max = BSTOperations.FindMax(BSTOperations.root);
            if (max != null)
            {
                System.Console.WriteLine("Max: " + max.Data);
            }
            System.Console.WriteLine("Is Binary search tree? " + BSTOperations.IsBinarySearchTree(BSTOperations.root));
        }
    }
}