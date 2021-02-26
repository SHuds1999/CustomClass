using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList    
{
   public class CustomList<T>
    {
        //member variable
        private T[] _items;

        private int count;
        private int capacity;

        public CustomList()
        {
            count = 0;
            capacity = 4;
            _items = new T[capacity];
        }

        public int Count
        {
            get
            {
                return count;
            }

        }           

        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }
        public T this[ int index]
        {
            get => _items[index];
            set => _items[index] = value;
        }
  

        public void Add(T itemToAdd)
        {
            if (count == capacity)
            {
                //create new  array
                capacity = capacity * 2;
                T[] StockAndBonds = new T[capacity];
                Console.WriteLine(capacity);
                for( int indexItem = 0; indexItem < count; indexItem++)
                {
                    StockAndBonds[indexItem] = _items[indexItem];                   
                }
                _items = StockAndBonds;

                //move items over
                //new array is now _items array.
            }
            _items[count] = itemToAdd;
            count++;
        }

        public void Remove(T itemToRemove)
        {

                //How to only remove one thing?  Maybe a bool???
                //why does count not go down when we remove
         
                T[] StockAndBonds = new T[capacity];
                
                Console.WriteLine(capacity);
                for( int i = 0, j = 0; i < count; i++ , j++)
                {
                    if ( _items[i].Equals(itemToRemove) )//ifitem equals to remove
                    {
                        j--;
                    count--;
                    }
                    
                    else
                    {
                    StockAndBonds[j] = _items[i];
                    }
                }

            _items = StockAndBonds;

      



        }










    }
}
