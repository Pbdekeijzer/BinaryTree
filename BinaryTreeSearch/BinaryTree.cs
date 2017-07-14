using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeSearch
{
    class BinaryTree<T> where T : IComparable<T>
    {
        public Node<T> Root { get; set; }

        public BinaryTree(Node<T> Root)
        {
            this.Root = Root;
        }

        public Node<T> SearchTree(Node<T> node, T Value)
        {
            if (node != null)
            {
                if (Value.CompareTo(node.Value) == 1)
                    return SearchTree(node.Right, Value);

                if (Value.CompareTo(node.Value) == -1)
                    return SearchTree(node.Left, Value);
            }
            return node;
        }

        //Inorder printing
        public void Inorder(Node<T> node)
        {
            if (node != null)
            {
                Inorder(node.Left);
                Console.Write(node.Value + " ");
                Inorder(node.Right);
            }
        }

        //Preorder printing
        public void Preorder(Node<T> node)
        {
            if (node != null)
            {
                Console.Write(node.Value + " ");
                Preorder(node.Left);
                Preorder(node.Right);
            }
        }

        //Postorder printing
        public void Postorder(Node<T> node)
        {
            if (node != null)
            {
                Preorder(node.Left);
                Preorder(node.Right);
                Console.Write(node.Value + " ");
            }
        }

        public void Insert(Node<T> Node, Node<T> newNode)
        {
            if (newNode.Value.CompareTo(Node.Value) == 1)
                if (Node.Right != null)
                    Insert(Node.Right, newNode);
                else
                {
                    Node.Right = newNode;
                    Node.Right.Parent = Node;
                }

            else
                if (Node.Left != null)
                    Insert(Node.Left, newNode);
            else
            {
                Node.Left = newNode;
                Node.Left.Parent = Node;
            }
        }

        public Node<T> searchTree(Node<T> Node, T Value)
        {
            if (Node != null)
            {
                if (Value.CompareTo(Node.Value) == 1)
                    return searchTree(Node.Right, Value);
                if (Value.CompareTo(Node.Value) == -1)
                    return searchTree(Node.Left, Value);
            }
            return Node;
        }

        public Node<T> DeleteNode(Node<T> Node, T Value)
        {
            if (Value.CompareTo(Node.Value) == 1)
                return DeleteNode(Node.Right, Value);
            if (Value.CompareTo(Node.Value) == -1)
                return DeleteNode(Node.Left, Value);

            //Value is found
            else
            {
                //No children
                if (Node.Left == null && Node.Right == null)
                    Node = null;

                //One child
                else if (Node.Left == null)
                    Node = Node.Right;
                else if (Node.Right == null)
                    Node = Node.Left;

                //Two children
                else
                {
                    Node<T> oldNodeLeft = Node.Left;
                    Node<T> oldNodeRight = Node.Right;

                    //if the right side has atleast one child, get the smallest value on the left side of that child (might be .Left.Left.Left.Left etc...) and replace node with the right child

                    if (Node.Right.Left != null)
                    {
                        Node<T> smallestNode = FindSmallest(Node.Right);
                        Node<T> smallestNodeChild = smallestNode.Right;
                        Node = smallestNode;
                        Node.Right = oldNodeRight;
                        smallestNode.Parent.Left = smallestNodeChild;
                    }

                    //else just replace the node with the right child
                    else
                        Node = Node.Right;

                    //Connect old left to new node
                    Node.Left = oldNodeLeft;
                }
            }
            return Node;
        }

        public Node<T> FindSmallest(Node<T> StartingNode)
        {
            if (StartingNode.Left != null)
                return FindSmallest(StartingNode.Left);
            return StartingNode;
        }
    }
}
