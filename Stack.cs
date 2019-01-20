using System;

namespace Data_Structures
{
    class Stack<T>
    {
        int capacity = -1;
        int top = -1;
        private T[] _stack;

        public Stack(int capacity = 5)
        {
            this.capacity = capacity;
            _stack = new T[capacity];
        }

        public Stack(int capacity, T value)
        {
            this.capacity = capacity;
            _stack = new T[capacity];
            Push(value);
        }

        public void Push(T item)
        {
            if(top < capacity)
            {
                top++;
                _stack[top] = item;
            }
        }

        public T Pop()
        {
            if (top >= 0)
            {
                T returnable = _stack[top];
                top--;
                return returnable;
            }
            else
                throw new IndexOutOfRangeException();
        }

        public T Peek()
        {
            if (top >= 0)
            {
                T returnable = _stack[top];
                return returnable;
            }
            else
                throw new IndexOutOfRangeException();
        }

        public T[] GetAllItems()
        {
            T[] returnable = new T[top + 1];
            Array.Copy(_stack, returnable, top + 1);
            return returnable;
        }

        public void Clear()
        {
            this._stack = new T[capacity];
            top = -1;
        }
    }
}