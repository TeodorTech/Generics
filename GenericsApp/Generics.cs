using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsApp
{
    public class GenericStack<T>
    {
        private readonly T[] _items;
        private int _currentIndex = -1;
        private readonly int _maxSize;

        public GenericStack(int maxSize = 10)
        {
            _maxSize = maxSize;
            _items = new T[maxSize];
        }
        public int Count => _currentIndex + 1;
        public void SetItemAtIndex(T item, int index)
        {

            try
            {
                _items[index] = item;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Enter a  position smaller than 10");
            }
        }

        public T GetItemByIndex(int index)
        {
            try
            {

                return _items[index];
            }
            catch (IndexOutOfRangeException)
            {
                throw;
            }

        }
        public T copy;
        public void SwapItemsByIndex(int index1, int index2)
        {
            copy = _items[index1];
            _items[index1] = _items[index2];
            _items[index2] = copy;

        }
       
     
    }
}
