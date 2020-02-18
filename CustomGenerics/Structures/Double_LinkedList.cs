using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomGenerics.Interfaces;
using System.Collections;

namespace CustomGenerics.Structures
{
    public class Double_LinkedList<T> : LinearDataStructureBase<T>, IEnumerable<T>
    {
        private Node<T> Head { get; set; }
        private Node<T> Last { get; set; }
        public void Agregar(T value)
        {
            Insert(value);
        }

        public T Remove()
        {
            var value = Get();
            Delete();
            return value;
        }
        protected override void Insert(T value)
        {

            if (Head == null)
            {
               Head = new Node<T>
                {
                    Value = value,
                    Next = null
                };
            }
            else
            {
                var current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node<T>
                {
                    Value = value,
                    Next = null
                };
            }

        }


        protected override void Delete()
        {
            if (Head != null)
            {
                Head = Head.Next;
            }
        }

        protected override T Get()
        {
            return Head.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var LinkedListCopy = this;
            while (LinkedListCopy.Head != null)
            {
                yield return LinkedListCopy.Remove();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
