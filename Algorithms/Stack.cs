using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    public class Stack<T>
    {
        private readonly List<T> _stackSource;

        public Stack()
        {
            _stackSource = new List<T>();
        }

        public int Size()
        {
            return _stackSource.Count;
        }

        public T Pop()
        {
            var elementsCount = Size();
            if (elementsCount == 0)
                return default;
            var elementToRemove = _stackSource[elementsCount - 1];
            _stackSource.Remove(elementToRemove);
            return elementToRemove;
        }

        public void Push(T val)
        {
            this._stackSource.Add(val);
        }

        public T Peek()
        {
            var elementsCount = Size();
            return elementsCount == 0 ? default : _stackSource[elementsCount - 1];
        }
    }
}