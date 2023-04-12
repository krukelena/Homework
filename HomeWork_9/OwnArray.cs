using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_9
{
   
    public class OwnArray<T>
    {
        public OwnArray() : this(4) { }

        public OwnArray(int capacity)
        {
            _size = 0;
            _capacity = capacity;
            _array = new T[_capacity];
        }

        public int Size => _size;

        private T[] _array;
        private int _size;
        private int _capacity;

        public void Add(T value)
        {
            _array[_size++] = value;

            if (_size == _capacity) 
            {
                ExpandArray();
            }
        }

        public void Remove() 
        {
            if (_size > 0)
            {
                _size--;
            }
        }

        public T GetValue(int index)
        {
            if (index >= 0 && index < Size)
            {
                return _array[index];
            }

            return default(T);
        }

        private void ExpandArray()
        {
            _capacity *= 2;  
            T[] newArray = new T[_capacity];

            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }
    }
}
