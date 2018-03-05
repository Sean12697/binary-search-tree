using System;

namespace Binary_Search_Tree
{
    class BSTree<T> : BinTree<T> where T : IComparable
    {
        public int Height()
        {
            return height(root);
        }

        protected int height(Node<T> tree)
        {
            if (tree == null) return 0;
            else return 1 + Math.Max(height(tree.Left), height(tree.Right));
        }

        public int Count()
        {
            return count(root);
        }

        private int count(Node<T> tree)
        {
            if (tree == null) return 0;
            return (1 + (count(tree.Left)) + (count(tree.Right)));
        }
        
        public Boolean Contains(T item)
        {
            return contains(item, ref root);
        }

        private Boolean contains(T item, ref Node<T> root)
        {
            if (root != null)
            {
                if (item.CompareTo(root.Data) == 0) return true;
                else if (item.CompareTo(root.Data) < 0 | (item.CompareTo(root.Data) > 0)) return contains(item, ref root.Left) | contains(item, ref root.Right);
            } return false;
        }

        public void RemoveItem(T item)
        {
            removeItem(item, ref root);
        }

        public void removeItem(T item, ref Node<T> tree)
        {
            if (Contains(item))
            {
                if (tree != null)
                {
                    if (item.CompareTo(tree.Data) < 0)
                    {
                        removeItem(item, ref tree.Left);
                    }
                    else if (item.CompareTo(tree.Data) > 0)
                    {
                        removeItem(item, ref tree.Right);
                    }
                    else
                    {
                        if (tree.Left == null)
                        {
                            tree = tree.Right;
                        }
                        else if (tree.Right == null)
                        {
                            tree = tree.Left;
                        }
                        else
                        {
                            T root = leastItem(tree.Right);
                            tree.Data = root;
                            removeItem(tree.Data, ref tree.Right);
                        }
                    }
                }
            }
        }
        
        public T leastItem(Node<T> tree)
        {
            if (tree.Left == null) return tree.Data;
            else return leastItem(tree.Left);
        }

        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
                tree = new Node<T>(item);
            else if (item.CompareTo(tree.Data) < 0)
                insertItem(item, ref tree.Left);
            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);
        }

    }

    /*
    class BSTree<T> : BinTree<T> where T : IComparable
    {

        public BSTree()
        {
            root = null;
        }

        public BSTree(Node<T> node)
        {
            root = node;
        }

        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
                tree = new Node<T>(item);

            else if (item.CompareTo(tree.Data) < 0)
                insertItem(item, ref tree.Left);

            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);
        }

        public int Height(Node<T> tree)
        {
            if (tree == null)
                return 0;
            else
            {
                return
                1 + Math.Max(Height(tree.Left), Height(tree.Right));
            }

        }

        public int Count()
        {
            int Count1 = 0;
            return count(root, ref Count1);
        }
        private int count(Node<T> tree, ref int Count1)
        {
            if (tree != null)
            {

                count(tree.Left, ref Count1);
                count(tree.Right, ref Count1);
                Count1++;

            }
            return Count1;
        }

        public Boolean Contains(T item)
        {
            return contains(item, ref root);
        }

        private Boolean contains(T item, ref Node<T> root)
        {
            if (root != null) {
                if (item.CompareTo(root.Data) == 0) return true;
                else if (item.CompareTo(root.Data) < 0 | (item.CompareTo(root.Data) > 0)) return contains(item, ref root.Left) | contains(item, ref root.Right);
            } return false;
        }

        public void RemoveItem(T item)
        {
            removeItem(item, ref root);
        }

        public void removeItem(T item, ref Node<T> tree)
        {
            if (tree != null) {
                if (item.CompareTo(tree.Data) < 0)
                {
                    removeItem(item, ref tree.Left);
                }
                else if (item.CompareTo(tree.Data) > 0)
                {
                    removeItem(item, ref tree.Right);
                }
                else
                {
                    if (tree.Left == null)
                    {
                        tree = tree.Right;
                    }
                    else if (tree.Right == null)
                    {
                        tree = tree.Left;
                    }
                    else
                    {
                        T root = leastItem(tree.Right);
                        tree.Data = root;
                        removeItem(tree.Data, ref tree.Right);
                    }
                }
            }
        }

        public T leastItem(Node<T> tree)
        {
            if (tree.Left == null) return tree.Data;
            else return leastItem(tree.Left);
        }

        /*
        public void RemoveItem(T item)
        {
            removeItem(item, ref root);
        }

        private void removeItem(T item, ref Node<T> tree)
        {
                if (tree != null)
                {
                    if (item.CompareTo(tree.Data) < 0)
                    {
                        removeItem(item, ref tree.Left);
                    }
                    else if (item.CompareTo(tree.Data) > 0)
                    {
                        removeItem(item, ref tree.Right);
                    }
                    else
                    {
                        if (tree.Left == null)
                        {
                            tree = tree.Right;
                        }
                        else if (tree.Right == null)
                        {
                            tree = tree.Left;
                        }
                        else
                        {
                            T root = leastItem(tree.Right);
                            tree.Data = root;
                            removeItem(tree.Data, ref tree.Right);
                        }
                    }
                }
        }

        /*
        private void removeItem(T item, ref Node<T> tree)
        {
            //BSTree<T> temp = new BSTree<T>(tree);
            if (tree == null) return;
            else if (item.CompareTo(tree.Data) < 0) removeItem(item, ref tree.Left);
            else if (item.CompareTo(tree.Data) > 0) removeItem(item, ref tree.Right);
            else if (item.CompareTo(tree.Data) == 0)
            {
                if (tree.Right == null && tree.Left == null)
                {
                    tree = null;
                }
                if (tree.Left == null)
                {
                    //Node<T> t = tree;
                    tree = tree.Right;
                }
                if (tree.Right == null)
                {
                    //Node<T> t = tree;
                    tree = tree.Left;
                }
                if (tree.Right != null && tree.Left != null)
                {
                    tree.Data = leastItem(tree.Right);
                    removeItem(tree.Data, ref tree);
                    //temp.root.Data = leastItem(temp.root.Right);
                    //temp.removeItem(temp.root.Data, ref temp.root);
                }
            }
        }
        
        private T leastItem(Node<T> tree)
        {
            if (tree.Left == null) return tree.Data;
            else return leastItem(tree.Left);
        }
        
    }
    */
}