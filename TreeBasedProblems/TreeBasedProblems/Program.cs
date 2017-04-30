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
            System.Console.Write("DFS: ");
            BSTOperations.TraverseTreeDFS(BSTOperations.root);
            System.Console.WriteLine();
            BSTOperations.TraverseBFS(BSTOperations.root);
            int itemToFind = 32;
            var value = BSTOperations.FindMin(BSTOperations.root, itemToFind);
            if (value == -1)
            {
                System.Console.WriteLine("Item not found");
            }
            else
            {
                System.Console.WriteLine("Item Found");
            }
        }
    }
}