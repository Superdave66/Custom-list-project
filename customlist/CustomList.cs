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


        private T[] items;
        public int Count { get { return count; } }
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
            items = new T[4];
            count = 0;

        }

        public void Add(T itemsToAdd)
        {
            items.Append(itemsToAdd);
            items[count] = itemsToAdd;
            count++;
            

        }

    }
}
