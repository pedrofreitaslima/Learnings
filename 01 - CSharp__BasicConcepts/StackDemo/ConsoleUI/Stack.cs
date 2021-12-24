using System;

namespace ConsoleUI
{
    public class Stack<T>
    {
        protected Entry<T> _top = default;

        public void Push(T data) => _top = new Entry<T>(_top, data);
        public T Pop()
        {
            if (_top == null) throw new InvalidOperationException();
            T result = _top.Data;
            _top = _top.Next;
            return result;
        }
    }
}
