using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Queue<T> : IEnumerable<T>
    {
        public LinkedList<T> _queue = new LinkedList<T>();

        public void Enqueue(T item)
        {
            _queue.AddLast(item);
        }
        public T Dequeue()
        {
            if(_queue.Count == 0)
            {
                throw new Exception("Queue is empty"); 
            }
            T value = _queue.Head.Value;
            _queue.RemoveFirst();
            return value;
        }
        public T Peek()
        {
            if (_queue.Count == 0)
            {
                throw new Exception("Queue is empty");
            }
            return _queue.Head.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _queue.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public override string ToString()
        {
            var current = _queue.Head;
            Console.WriteLine("Print Queue");
            while (current != null)
            {
                Console.Write(current.Value + " -- ");
                current = current.Next;
            }
            return string.Empty;
        }
    }
}
