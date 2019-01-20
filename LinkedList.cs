using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class LinkedList<T>
    {
        private Node<T>[] nodes;

        public int count = 0;
        public int capacity = -1;
        public bool isEmpty = true;
        private const int _defaultCapacity = 10;
        private int lastIndex = 0;

        public LinkedList()
        {
            nodes = new Node<T>[_defaultCapacity];
        }

        public LinkedList(int capacity)
        {
            this.capacity = capacity;
            nodes = new Node<T>[capacity];
        }

        public LinkedList(T item)
        {
            nodes = new Node<T>[_defaultCapacity];
            nodes[0].value = item;
            count++;
            isEmpty = false;
        }
        
        public Node<T> GetFirstNode()
        {
            if (!isEmpty)
            {
                return nodes[0];
            }
            else
                throw new IndexOutOfRangeException();
        }

        public Node<T> GetNodeAt(int index)
        {
            Node<T> n = null;
            if (index >= 0 && index <= lastIndex)
            {
                n = nodes[index];
                return n;
            }
            else
                throw new IndexOutOfRangeException();
        }

        public Node<T> GetLastNode()
        {
            if (!isEmpty)
            {
                return nodes[lastIndex];
            }
            else
                throw new IndexOutOfRangeException();
        }

        public T GetFirstItem()
        {
            if (!isEmpty)
            {
                return nodes[0].value;
            }
            else
                throw new IndexOutOfRangeException();
        }

        public T GetItemAt(int index)
        {
            Node<T> n = GetNodeAt(index);
            return n.value;
        }

        public T GetLastItem()
        {
            if (!isEmpty)
            {
                return nodes[lastIndex].value;
            }
            else
                throw new IndexOutOfRangeException();
        }

        public void AddNode(T item)
        {
            Node<T> n = new Node<T>();
            if (count < capacity)
            {
                lastIndex++;
                count++;
                nodes[lastIndex].value = item;
                if (isEmpty)
                    isEmpty = false;
            }
            else
                throw new Exception("The maximum specified limit of the list has been reached.");
        }

        public void EditNode(int index, T item)
        {
            if(index >= 0 && index <= lastIndex)
            {
                nodes[index].value = item;
            }
            throw new IndexOutOfRangeException();
        }

        public void RemoveNode(int index)
        {
            if (index >= 0 && index <= lastIndex)
            {
                Node<T>[] n = new Node<T>[capacity];
                nodes[index] = null;
                count--;
                lastIndex--;

                if (count == 0)
                    isEmpty = true;
            }
            else throw new IndexOutOfRangeException();
        }

        /// <summary>
        /// Removes the node at the specified location and shifts all the following nodes down the list
        /// </summary>
        public void RemoveNodeAndShift(int index)
        {
            if (index >= 0 && index <= lastIndex)
            {
                Node<T>[] n = new Node<T>[capacity];
                for (int i = index; i <= capacity; i++)
                {
                    nodes[i] = nodes[i + 1];
                }

                nodes[lastIndex] = null;
                count--;
                lastIndex--;
            }
        }
    }
}