namespace FindaCorrespondingNodeofaBinaryTreeinaCloneofThatTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] case1 = new int[] { 7, 4, 3, null, null, 6, 19 };
            var treeNode = new Solutions();
            treeNode.GetTargetCopy()
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solutions
    {
        public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            return Dfs(original, cloned, target);
        }

        private TreeNode Dfs(TreeNode original, TreeNode cloned, TreeNode target)
        {
            if (original == null || cloned == null) return null;
            if (original == target) return cloned;

            var left = Dfs(original.left, cloned.left, target);
            if(left != null) return left;
            else 
                return Dfs(original.right, cloned.right, target);
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) {  val = x; }
    }
}