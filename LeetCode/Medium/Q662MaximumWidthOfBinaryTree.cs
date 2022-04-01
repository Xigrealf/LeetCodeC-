using LeetCode.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    public class Q662MaximumWidthOfBinaryTree
    {

        public void Solution()
        {
            TreeNode root = new TreeNode(1, new TreeNode(3, new TreeNode(5, new TreeNode(6), null)), new TreeNode(2, null, new TreeNode(9, new TreeNode(7), null)));
            var a = WidthOfBinaryTree(root);
        }

        List<TreeNode?> treePositions = new List<TreeNode?>();
        int depth = 0, maxWidth = 0;
        public int WidthOfBinaryTree(TreeNode root)
        {
            BFSTraversal(root);

            for (int i = 0; i < depth; i++)
            {
                int left = 0, right = Convert.ToInt32(Math.Pow(2, i));
                bool leftFound = false, rightFound = false;

                if (i == 0)
                {
                    continue;
                }
                List<TreeNode?> treeNodes = new List<TreeNode?>();
                treeNodes.AddRange(treePositions.GetRange((2 * i - 1), right));
                right--;
                while ((left < right) && !(leftFound && rightFound))
                {
                    if (treeNodes[left].val == 0)
                        left++;
                    else
                        leftFound = true;
                    if (treeNodes[right].val == 0)
                        right--;
                    else
                        rightFound = true;
                }
                maxWidth = Math.Max(maxWidth, ((right - left) + 1));
            }

            return maxWidth;
        }

        public void BFSTraversal(TreeNode root)
        {
            LinkedList<TreeNode?> list = new LinkedList<TreeNode?>();
            list.AddLast(root);
            while (list.Count > 0)
            {
                int size = list.Count;

                while (size-- > 0)
                {
                    TreeNode reminderNode = list.FirstOrDefault();
                    treePositions.Add(reminderNode);
                    list.RemoveFirst();
                    if (reminderNode.val == 0)
                        continue;
                    if (reminderNode.left != null)
                        list.AddLast(reminderNode.left);
                    else
                        list.AddLast(new TreeNode());
                    if (reminderNode.right != null)
                        list.AddLast(reminderNode.right);
                    else
                        list.AddLast(new TreeNode());
                }
                depth++;
            }
            depth--;
        }
    }
}
