using Binary_Search_Tree_Portfolio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            AVLTree<int> tree = new AVLTree<int>();
            // Node<int>[] nodes = { new Node<int>(10), new Node<int>(15), new Node<int>(17), new Node<int>(23), new Node<int>(25) };
            tree.InsertItem(25);
            tree.InsertItem(17);
            tree.InsertItem(15);
            tree.InsertItem(23);
            tree.InsertItem(10);
            String s = null;
            tree.InOrder(ref s);

            Console.WriteLine("AVL Height " + tree.Height());
            Console.WriteLine("AVL InOrder " + s);

            BSTree<int> tree2 = new BSTree<int>();
            // Node<int>[] nodes = { new Node<int>(10), new Node<int>(15), new Node<int>(17), new Node<int>(23), new Node<int>(25) };
            tree2.InsertItem(25);
            tree2.InsertItem(17);
            tree2.InsertItem(15);
            tree2.InsertItem(23);
            tree2.InsertItem(10);
            String s2 = null;
            tree2.InOrder(ref s2);

            Console.WriteLine("BSTree Height " + tree2.Height());
            Console.WriteLine("BSTree InOrder " + s2);
            Console.ReadKey();

            //Node<int>[] a =
            //{
            //    new Node<int>(1), new Node<int>(2), new Node<int>(3), new Node<int>(4), new Node<int>(5),
            //    new Node<int>(6), new Node<int>(7), new Node<int>(8), new Node<int>(9), new Node<int>(10), new Node<int>(11)
            //};
            //a[0].Left = a[1];
            //a[0].Right = a[2];
            //a[1].Left = a[3];
            //a[1].Right = a[4];
            //a[2].Left = a[5];
            //a[2].Right = a[6];
            //a[4].Right = a[7];
            //a[7].Left = a[8];
            //a[7].Right = a[9];
            //a[9].Right = a[10];

            //BSTree<int> bt = new BSTree<int>();
            //// for (int i = 0; i < 13; i++) bt.InsertItem(i);
            //bt.InsertItem(5);
            //bt.InsertItem(4);
            //bt.InsertItem(8);
            //bt.InsertItem(6);

            //// HEIGHT
            //Console.WriteLine("Height: " + bt.Height());

            //// COUNT
            //Console.WriteLine("Amount: " + bt.Count());

            //String s1 = null;
            //bt.PreOrder(ref s1);
            //Console.WriteLine("BST: " + s1);

            //// CONTAINS
            //int[] n = new int[] { 8, 14 };
            //foreach (int x in n)
            //{
            //    if (bt.Contains(x)) Console.WriteLine("BST Contains " + x);
            //    else Console.WriteLine("BST Does Not Contains " + x);
            //}

            //// REMOVE
            //int y = 5;
            //bt.RemoveItem(y);
            //if (bt.Contains(y)) Console.WriteLine("BST Contains " + y);
            //else Console.WriteLine("BST Does Not Contains " + y);

            //// HEIGHT
            //Console.WriteLine("Height: " + bt.Height());

            //String s2 = null;
            //bt.PreOrder(ref s2);
            //Console.WriteLine("BST: " + s);
        }
    }
}