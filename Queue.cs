using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class Queue<T>
    {
        int lastIndex = -1;
        int capacity = -1;
        private const int _defaultCapacity = 10;
        private Node<T> front;
        private Node<T> rear;

        private void ConstructorBase()
        {
            front = new Node<T>();
            rear = new Node<T>();

            front.nextNode = rear;
            front.previousNode = rear;
            rear.nextNode = front;
            rear.previousNode = front;
        }

        public Queue()
        {
            ConstructorBase();
            capacity = _defaultCapacity;
        }

        public Queue(int capacity)
        {
            ConstructorBase();
            this.capacity = capacity;
        }

        public Queue(T item, int capacity)
        {
            ConstructorBase();
            front.value = item;
            this.capacity = capacity;
            lastIndex++;
        }

        public void Enqueue(T item)
        {
            if (lastIndex < capacity)
            {
                Node<T> newNode = new Node<T>();
                Node<T> previousEndNode = new Node<T>();
                lastIndex++;

                previousEndNode = rear;
                rear = newNode;
                rear.previousNode = previousEndNode;
                previousEndNode.nextNode = rear;
            }
            else
                throw new IndexOutOfRangeException();
        }

        public T Peek()
        {
            if (lastIndex >= 0)
            {
                return front.value;
            }
            else
                throw new IndexOutOfRangeException();
        }

        public T Dequeue()
        {
            if (lastIndex >= 0)
            {
                T returnable = front.value;
                front = front.nextNode;
                front.previousNode = rear;
                lastIndex--;
                return returnable;
            }
            else
                throw new IndexOutOfRangeException();
        }

        public void ClearQueue()
        {
            for(int i = 0; i < lastIndex; i++)
            {
                if(front != null)
                {
                    front.previousNode = null;
                    front = front.nextNode;
                }
            }
            lastIndex = -1;
        }
    }
}