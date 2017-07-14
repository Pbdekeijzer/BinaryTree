using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeSearch
{

    class Node<T> : IComparable
    {
        public T Value { get; set; }
        public Node<T> Right { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Parent { get; set; }

        public Node(T Value)
        {
            this.Value = Value;
        }

        public int CompareTo(object other)
        {
            if (other == null) return 2;

            var otherNode = other as Node<T>;
            if (otherNode != null)
            {
                var otherNode2 = otherNode as IComparable;
                if (otherNode2 != null)
                    return otherNode2.CompareTo(otherNode.Value);
                else
                    return 2;
            }

            throw new ArgumentException("Argument is not a Node<T>");
        }


    }
}
