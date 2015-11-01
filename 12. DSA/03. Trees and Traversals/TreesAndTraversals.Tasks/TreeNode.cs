namespace TreesAndTraversals.Tasks
{
    using System.Collections.Generic;

    public class TreeNode
    {
        public TreeNode(int value)
        {
            this.Value = value;
            this.Children = new List<TreeNode>();
        }

        public int Value { get; set; }

        public List<TreeNode> Children { get; set; }

        public TreeNode Parent { get; set; }
    }
}
