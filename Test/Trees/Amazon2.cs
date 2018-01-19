namespace Test.Trees
{
    public class Amazon2
    {
        private static void Insert(Node root, int data)
        {
            var current = root;

            while (current != null)
            {
                if (current.Data < data)
                {
                    if (current.Left == null)
                    {
                        current.Left = new Node(data);
                        break;
                    }
                    current = current.Left;
                }
                else
                {
                    if (current.Data > data)
                    {
                        current.Right = new Node(data);
                        break;
                    }

                    current = current.Right;
                }
            }
        }


        private static int FindDistance(Node n, int k, int count)
        {
            if (n == null)
            {
                return -1;
            }
            if (n.Data == k)
            {
                return count;
            }
            if (n.Data < k)
            {
                return FindDistance(n.Right, k, count++);
            }

            return FindDistance(n.Left, k, count++);
        }


        public static int GetDistance(int[] a, int num, int node1, int node2)
        {
            if (num == 0)
            {
                return -1;
            }

            var root = new Node(a[0]);

            foreach (var item in a)
            {
                Insert(root, item);
            }

            var distanceToFirstNode = -1;
            var distanceToSecondNode = -1;

            if (root.Data > node1 && root.Data > node2)
            {
                distanceToFirstNode = FindDistance(root.Left, node1, 0);
                distanceToSecondNode = FindDistance(root.Left, node2, 0);
            }
            else if (root.Data < node1 && root.Data < node2)
            {
                distanceToFirstNode = FindDistance(root.Right, node1, 0);
                distanceToSecondNode = FindDistance(root.Right, node2, 0);
            }
            else if (root.Data < node1 && root.Data > node2)
            {
                distanceToFirstNode = FindDistance(root.Right, node1, 0);
                distanceToSecondNode = FindDistance(root.Left, node2, 0);
            }
            else if (root.Data > node1 && root.Data < node2)
            {
                distanceToFirstNode = FindDistance(root.Left, node1, 0);
                distanceToSecondNode = FindDistance(root.Right, node2, 0);
            }

            if (distanceToFirstNode == -1 || distanceToSecondNode == -1)
            {
                return -1;
            }

            return distanceToSecondNode + distanceToFirstNode;
        }
    }
}
