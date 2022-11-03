namespace Core.Utility
{
    /// <summary>
    /// Original implementation is that of Ronnie Overby from here
    /// https://stackoverflow.com/questions/66893/tree-data-structure-in-c-sharp
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TreeNode<T>
    {
        public List<TreeNode<T>> Children { get; set; } = new();
        public T Value { get; }
        public TreeNode<T> Parent { get; private set; }
        public int Level { get; set; } = 0;
        public bool IsLeaf => Children == null || Children.Count == 0;
        public bool IsVisible { get; set; } = true;

        public TreeNode(T value)
        {
            Value = value;
        }

        public TreeNode<T> this[int i]
        {
            get { return Children[i]; }
        }

        /// <summary>
        /// This is quite tricky because upon sending response over to FE
        /// The response breaks because of infinite references
        /// Setting an existing parent on an item will link the entire tree there
        /// And the references would just go indefinetily
        /// That's why we opt for removing parent reference here
        /// Instead we just set the Value as a new object
        /// Other option would be to expand on Visitor patern and create a ReferenceKillerVisitor 
        /// And loop through the tree to kill all parent references
        /// For the same reason we are calculating Level inside Visitor, instead of keeping it as an Action here
        /// </summary>
        /// <param name="value"></param>
        /// <param name="removeParentRef"></param>
        /// <returns></returns>
        public TreeNode<T> AddChild(T value, bool removeParentRef = true)
        {
            TreeNode<T> node;
            if (removeParentRef)
            {
                node = new TreeNode<T>(value)
                {
                    Parent = new TreeNode<T>(Value)
                };
            }
            else
            {
                node = new TreeNode<T>(value) { Parent = this };
            }

            Children.Add(node);
            return node;
        }

        public TreeNode<T>[] AddChildren(params T[] values)
        {
            return values.Select(v => AddChild(v)).ToArray();
        }

        public TreeNode<T>[] AddChildren(IEnumerable<T> values, bool removeParentRef = true)
        {
            return values.Select(v => AddChild(v, removeParentRef)).ToArray();
        }

        public bool RemoveChild(TreeNode<T> node)
        {
            return Children.Remove(node);
        }

        public void Traverse(Action<T> action)
        {
            action(Value);
            foreach (var child in Children)
            {
                child.Traverse(action);
            }
        }

        public void TraverseParent(Action<TreeNode<T>> action)
        {
            if (Parent != null)
            {
                action(Parent);
                Parent.TraverseParent(action);
            }
        }

        public IEnumerable<T> Flatten()
        {
            return new[] { Value }.Concat(Children.SelectMany(x => x.Flatten()));
        }

        public TreeNode<T> InsertChild(TreeNode<T> parent, T value)
        {
            var node = new TreeNode<T>(value)
            {
                Parent = parent
            };
            parent.Children.Add(node);
            return node;
        }
    }
}
