using System.Collections.Generic;

namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution 
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2) 
        {
            var values = new List<int>();
            var index = 0;
            var isSame = true;


            Traverse(root1);
            Traverse2(root2);

            return isSame && index == values.Count;


            void Traverse(TreeNode node)
            {
                if (node is null) return;

                if (node.left is null && node.right is null)
                {
                    values.Add(node.val);
                    return;
                }

                Traverse(node.left);
                Traverse(node.right);
            }

            void Traverse2(TreeNode node)
            {
                if (!isSame) return;

                if (node is null) return;

                if (node.left is null && node.right is null)
                {
                    if (index >= values.Count)
                    {
                        isSame = false;
                    }

                    else if (values[index] != node.val)
                    {
                        isSame = false;
                    }

                    index += 1;
                    return;
                }

                Traverse2(node.left);
                Traverse2(node.right);
            }
        }
    }
}