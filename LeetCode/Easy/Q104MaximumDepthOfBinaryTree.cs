using LeetCode.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class Q104MaximumDepthOfBinaryTree
    {
        public void Solution()
        {
            TreeNode root = new TreeNode(3, new TreeNode(9, null, null), new TreeNode(20, new TreeNode(15, null, null), new TreeNode(7, null, null)));
            var a = MaxDepth(root);
        }

        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            int level = 0;
            LinkedList<TreeNode> list = new LinkedList<TreeNode>();
            list.AddLast(root);
            while (list.Count > 0)
            {
                int size = list.Count;

                while (size-- > 0)
                {
                    TreeNode reminderNode = list.FirstOrDefault();
                    list.RemoveFirst();

                    if (reminderNode.left != null)
                        list.AddLast(reminderNode.left);
                    if (reminderNode.right != null)
                        list.AddLast(reminderNode.right);
                }

                level++;
            }
            return level;
        }
    }
}
