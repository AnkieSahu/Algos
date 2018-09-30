using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class BinaryTreeNode<T> : IComparable<T>
        where T : IComparable<T>
    {
        public BinaryTreeNode(T value)
        {
            Value = value;
        }
        public T Value { get; set; }
        public BinaryTreeNode<T> LeftChild { get; set; }
        public BinaryTreeNode<T> RightChild { get; set; }

        public int CompareTo(T other)
        {
            return Value.CompareTo(other);
        }
    }

    public class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {
        private BinaryTreeNode<T> Head { get; set; }
        private int Count{ get; set; }
        #region Add
        void Add(T value)
        {
            if (Head == null)
            {
                Head = new BinaryTreeNode<T>(value);
            }
            else
            {
                AddTo(Head,value);
            }
            Count++;
        }

        private void AddTo(BinaryTreeNode<T> node, T value)
        {
                if(node.Value.CompareTo(value) > 0)
                {
                if(node.LeftChild == null)
                {
                    node.LeftChild = new BinaryTreeNode<T>(value);
                }
                else
                    AddTo(node.LeftChild, value);
                }
                else
                {
                if (node.RightChild== null)
                {
                    node.RightChild = new BinaryTreeNode<T>(value);
                }
                else
                    AddTo(node.RightChild, value);
                }
            
        }
        #endregion


        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
