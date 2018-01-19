using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Trees
{
    public class LowestAncestor
    {
        public static Node GetAncestor(Node root, int n1, int n2)
        {
            if (root == null)
            {
                return null;
            }
            if (root.Left.Data == n1 || root.Left.Data == n2 || root.Right.Data == n1 || root.Right.Data == n2)
            {
                return root;
            }

            var l = GetAncestor(root.Left, n1, n2);
            var r = GetAncestor(root.Right, n1, n2);

            if (l == null && r == null)
            {
                return null;
            }
            if (l != null && r != null)
            {
                return root;
            }

            return (l == null) ? r : l;
        }


        public static int LowestCommonAncestor(Node root, int n1, int n2)
        {
            if (root == null)
            {
                return -1;
            }
            if (root.Data == n1 || root.Data == n2)
            {
                return root.Data;
            }
            var l = LowestCommonAncestor(root.Left, n1, n2);
            var r = LowestCommonAncestor(root.Right, n1, n2);
            if (l == -1 && r == -1)
            {
                return -1;
            }
            if (l != -1 && r != -1)
            {
                return root.Data;
            }

            return (l == -1) ? r : l;
        }
    }
}
