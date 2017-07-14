using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> testTree = new BinaryTree<int>(new Node<int>(10));
            testTree.Insert(testTree.Root, new Node<int>(6));
            testTree.Insert(testTree.Root, new Node<int>(3));
            testTree.Insert(testTree.Root, new Node<int>(1));
            testTree.Insert(testTree.Root, new Node<int>(-4));
            testTree.Insert(testTree.Root, new Node<int>(4));
            testTree.Insert(testTree.Root, new Node<int>(5));
            testTree.Insert(testTree.Root, new Node<int>(15));
            testTree.Insert(testTree.Root, new Node<int>(12));
            testTree.Insert(testTree.Root, new Node<int>(14));
            testTree.Insert(testTree.Root, new Node<int>(27));
            testTree.Insert(testTree.Root, new Node<int>(24));
            testTree.Insert(testTree.Root, new Node<int>(19));
            testTree.Insert(testTree.Root, new Node<int>(23));
            testTree.Insert(testTree.Root, new Node<int>(21));
            testTree.Insert(testTree.Root, new Node<int>(22));

            Console.WriteLine(testTree.Root.Value);
            Console.WriteLine(testTree.Root.Right.Value);
            Console.WriteLine(testTree.Root.Right.Right.Value);
            Console.WriteLine(testTree.Root.Right.Right.Left.Value);
            Console.WriteLine(testTree.Root.Right.Right.Left.Left.Value);
            Console.WriteLine(testTree.Root.Right.Right.Left.Left.Right.Value);
            Console.WriteLine(testTree.Root.Right.Right.Left.Left.Right.Left.Value);

            testTree.DeleteNode(testTree.Root, -4);

            Console.WriteLine(testTree.Root.Left.Left.Left.Left.Value);

            //Console.WriteLine("AFTER DELETION: ");
            //Console.WriteLine(testTree.Root.Value);
            //Console.WriteLine(testTree.Root.Right.Value);
            //Console.WriteLine(testTree.Root.Right.Right.Value);
            //Console.WriteLine(testTree.Root.Right.Right.Left.Value);
            //Console.WriteLine(testTree.Root.Right.Right.Left.Left.Value);
            //Console.WriteLine(testTree.Root.Right.Right.Left.Left.Left.Value);
            //Console.WriteLine(testTree.Root.Right.Right.Left.Left.Left.Right.Value);

            Console.ReadKey();
        }
    }
}
