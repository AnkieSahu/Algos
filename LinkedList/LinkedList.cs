using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{

    public class LinkedListNode<T>
    {
        public T Value { get; set; }
        public LinkedListNode<T> Next { get; set; }
        public LinkedListNode(T value)
        {
            Value = value;
        }
    }
    public class LinkedList<T> : ICollection<T>
    {
        public LinkedListNode<T> Head { get; private set; }
        public LinkedListNode<T> Tail { get; private set; }

        #region Add
        public void AddFirst(T value)
        {
            AddFirstNode(new LinkedListNode<T>(value));
        }
        public void AddFirstNode(LinkedListNode<T> node)
        {
            Count++;
            LinkedListNode<T> temp = Head;
            Head = node;
            Head.Next = temp;
            if (Count == 1)
                Tail = Head;
        }
        public void AddLast(T value)
        {
            AddLastNode(new LinkedListNode<T>(value));
        }
        public void AddLastNode(LinkedListNode<T> node)
        {
            Count++;
            if (Count == 1)
                Head = node;
            else
                Tail.Next = node;
            Tail = node;
        }
        #endregion

        #region Remove
        public void RemoveFirst()
        {
            if (Count == 1)
            {
                Head = Tail = null;
            }
            else
            {
                Head = Head.Next;
            }
            Count--;
        }
        public void RemoveLast()
        {
            if (Count == 1)
            {
                Head = Tail = null;
            }
            else
            {
                LinkedListNode<T> node = Head;
                while (node.Next != Tail)
                {
                    node = node.Next;
                }
                node.Next = null;
                Tail = node;
                Count--;
            }
        }
        #endregion

        #region ICollection
        public int Count { get; private set; }
        public bool IsReadOnly { get { return false; } }
        public void Add(T item)
        {
            AddFirst(item);
        }
        public void Clear()
        {
            Head = Tail = null;
            Count = 0;
        }
        public bool Contains(T item)
        {
            var current = Head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                    return true;
                current = current.Next;
            }
            return false;
        }
        public void CopyTo(T[] array, int arrayIndex)
        {
            var current = Head;
            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }
        public bool Remove(T item)
        {
            if (Count > 0)
            {
                LinkedListNode<T> previous = null;
                var current = Head;
                while (current != null)
                {
                    if (current.Value.Equals(item))
                    {
                        if (previous == null)
                            RemoveFirst();
                        else if (current.Next == null)
                            RemoveLast();
                        else
                        {
                            previous.Next = current.Next;
                        }
                        return true;
                    }
                    previous = current;
                    current = current.Next;
                    Count--;
                }
            }
            return false;
        }
        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        #endregion

        public override string ToString()
        {
            var current = Head;
            Console.WriteLine("Print Linked List");
            while (current != null)
            {
                Console.Write(current.Value + " -- ");
                current = current.Next;
            }
            return string.Empty;
        }
    }
}
