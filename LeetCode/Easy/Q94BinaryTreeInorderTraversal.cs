using LeetCode.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class Q94BinaryTreeInorderTraversal
    {
        public void Solution()
        {
            TreeNode root = new TreeNode(1, null, new TreeNode(2, new TreeNode(3, null, null), null));

            var a = InorderTraversal(root);
            var b = InorderTraversalOptimal(root);
        }

        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();
            if (root != null)
            {
                result.AddRange(InorderTraversal(root.left));

                result.Add(root.val);

                result.AddRange(InorderTraversal(root.right));
            }
            return result;
        }

        public IList<int> InorderTraversalOptimal(TreeNode root)
        {
            List<int> result = new List<int>();
            TreeNode current = root;
            TreeNode previous;

            while (current != null)
            {
                if (current.left == null)
                {
                    result.Add(current.val);
                    current = current.right;
                }
                else
                {
                    previous = current.left;
                    while (previous.right != null)
                    {
                        previous = current.right;
                    }
                    previous.right = current;
                    TreeNode temp = current;
                    current = current.left;
                    temp.left = null;
                }
            }
            return result;
        }
    }
}
