using System.ComponentModel.Design.Serialization;
using System.Xml.Linq;

namespace Leetcode_100_Same_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);

            var root2 = new TreeNode(1);
            root2.left = new TreeNode(2);
            root2.right = new TreeNode(3);

            Console.WriteLine(IsSameTree(root, root2));
        }

        static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }

            if (p != null && q != null)
            {
                return (p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right));
            }

            return false;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
      
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
