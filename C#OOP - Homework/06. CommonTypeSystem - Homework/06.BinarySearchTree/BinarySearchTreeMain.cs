namespace BinarySearchTree
{
    using System;
    using System.Text;

    public class BinarySearchTreeMain
    {
        /* Define the data structure binary search tree with operations for "adding new element", 
          "searching element" and "deleting elements". It is not necessary to keep the tree balanced.
           Implement the standard methods from System.Object – ToString(), Equals(…), GetHashCode() 
           and the operators for comparison == and !=.
           Add and implement the ICloneable interface for deep copy of the tree.
           Remark: Use two types – structure BinarySearchTree (for the tree) and class TreeNode 
           (for the tree elements). Implement IEnumerable<T> to traverse the tree.
         */

        public static void Main()
        {
            TestBinarySearchTree();
        }

        private static void TestBinarySearchTree()
        {
            var sb = new StringBuilder();

            var tree = new BinarySearchTree<int>(15);

            for (int i = 0; i < 30; i++)
            {
                tree.Add(i);
            }

            var clonedNode = (TreeNode<int>)tree.Root.Clone();

            sb.AppendLine(tree.ToString())
                .AppendLine("Tree root: " + tree.Root.ToString())
                .AppendLine("Tree contains 7? " + tree.Contains(7).ToString())
                .AppendLine("Cloned root: " + clonedNode.ToString())
                .AppendLine("Cloned Equals root? " + (clonedNode.Equals(tree.Root)).ToString())
                .AppendLine("Cloned == root? " + (clonedNode == tree.Root).ToString())
                .AppendLine("Cloned != root? " + (clonedNode != tree.Root).ToString())
                .AppendLine("12 deleted. New tree:");

            Console.Write(sb.ToString());

            tree.Delete(12);
            Console.WriteLine(tree.ToString());
        }
    }
}
