using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class Stack
    {
        private List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("You can t add a null");

            _list.Add(obj);
            int elements = _list.Count;

            if (elements > 1)
            {
                for (int i = elements - 1; i > 0; i--)
                {
                    _list[i] = _list[i - 1];
                }

                _list[0] = obj;
            }
        }

        public object Pop()
        {
            if (_list.Count == 0)
                throw new  InvalidOperationException("There are no lements in stack");
            object ToReturn = _list[0];

            int elements = _list.Count;
            for (int i = 0; i < elements - 1; i++)
            {
                _list[i] = (int) _list[i + 1];
            }

            _list.Remove(elements - 1);
            return (ToReturn);

        }
    }
}
