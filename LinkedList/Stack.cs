using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Stack<T> : IEnumerable<T>
    {
        public LinkedList<T> _stack = new LinkedList<T>();

        public void Push(T item)
        {
            _stack.AddFirst(item);
        }
        public T Pop()
        {
            if(_stack.Count == 0)
            {
                throw new Exception("Stack is empty"); 
            }
            T value = _stack.Head.Value;
            _stack.RemoveFirst();
            return value;
        }
        public T Peek()
        {
            if (_stack.Count == 0)
            {
                throw new Exception("Stack is empty");
            }
            return _stack.Head.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _stack.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public override string ToString()
        {
            var current = _stack.Head;
            Console.WriteLine("Print Stack");
            while (current != null)
            {
                Console.Write(current.Value + " -- ");
                current = current.Next;
            }
            return string.Empty;
        }
    }
}
