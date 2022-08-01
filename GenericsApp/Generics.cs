using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsApp
{
    public class GenericStack<T> where T : IComparable
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
                Console.WriteLine("Enter an index smaller than 10");
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
            try
            {
                copy = _items[index1];
                _items[index1] = _items[index2];
                _items[index2] = copy;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Enter an index smaller than 10");
            }
        }

        public int count1 = 0;
        public int count2 = 0;
        public T copy1;
        public T copy2;
        public void SwapItemsByValue(T value1, T value2)
        {
            foreach (T item in _items)
            {
                if (item.CompareTo(value1) == 0)
                {
                    
                    copy1 = item;
                    foreach (T element in _items)
                    {
                        if (element.CompareTo(value2) == 0)
                        {
                            
                            copy2 = element;
                            break;
                        }
                        else count2++;
                    }
                    break;
                }
                else count1++;
            }
           
                copy = _items[count1];
                _items[count1] = _items[count2];
                _items[count2] = copy;
            
          
        }

        public int countindex = 0;

        public void SwapItems(int index, T value)
        {
            foreach (T item in _items)
            {
                if (item.CompareTo(value) == 0)
                {
                    break;
                }
                else countindex++;
            }
            try
            {
                copy = _items[index];
                _items[index] = _items[countindex];
                _items[countindex] = copy;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Enter an index smaller than 10");
            }


        }
    }


}

