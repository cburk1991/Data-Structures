using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class BinarySearchTree<T>
    {
        // UNFINISHED //
        public BSTNode<T> root = null;

        public BinarySearchTree()
        {
        }

        public BinarySearchTree(int key)
        {
            root = new BSTNode<T>();
            root.key = key;
        }

        public BinarySearchTree(T item, int key)
        {
            root = new BSTNode<T>();
            root.key = key;
            root.value = item;
        }

        public T Search(int key)
        {
            return Search(this.root, key);
        }

        private T Search(BSTNode<T> root, int key)
        {
            if (root.key == key)
                return root.value;
            if (key > root.key)
                return Search(root.right, key);
            else
                return Search(root.left, key);

        }

        public void Insert(BSTNode<T> root, T item, int key)
        {
            if(root == null)
            {
                root = new BSTNode<T>();
                root.key = key;
                root.value = item;
                return;
            }

            if(key > root.key)
            {
                Insert(root.right, item, key);
            }

            if(key < root.key)
            {
                Insert(root.left, item, key);
            }
            return;
        }

        //public void RemoveNode()

        public bool IsLocationValid(int key, BSTNode<T> compareAgainst)
        {
            return true;
        }
    }

    public class BSTNode<T>
    {
        public int? key = 0;
        public T value;
        public BSTNode<T> left = null;
        public BSTNode<T> right = null;
    }
}
