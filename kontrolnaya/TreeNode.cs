using System;
using System.Collections.Generic;
using System.Text;

namespace kontrolnaya
{
    class TreeNode<T>
    {
        public T data;
        public TreeNode<T> left;
        public TreeNode<T> right;
        public TreeNode (T data)
        {
            this.data = data;
            left = null;
            right = null;
        }
    }
}
