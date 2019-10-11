using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListTests
{
    public class CustomList<T>
    {
        private int count;
        private int capacity;

        private T[] items;

        public int Count { get { return count; } }
        public int Capacity { get { return capacity; } }
        public T this[int index]


        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }


        public CustomList()
        {
            capacity = 4;
            items = new T[capacity];
            count = 0;
        }

        public void Add(T itemsToAdd)
        {
           
            items[count] = itemsToAdd;
          
            while (count < capacity)
            {



                count++;

                if (count == capacity)
                {
                    T[] copyitems = new T[2 * capacity];
                    copyitems[0] = items[0];
                    for (int i = 0; i < count; i++)
                    {
                        copyitems[i] = items[i];
                    }

                    items = copyitems;
                    count++;
                    break;
                }
                break;


            }





        }
      
    }
}

