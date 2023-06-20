using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        private readonly object Mylist;

        //Member Variables (HAS A)
        private T[] items;
        private int capacity;
        private int count;
        private static object list2;
        private static object list1;

        public int Count => count;

        public int Capacity => capacity;




        //Constructor
        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];

            //capacity = 
            //count =
            //items = 
        }
        public int Counts
        {
            get { return count; }
        }
        public int Capacities
        {
            get { return capacity; }
        }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }

                return items[index];
            }
            set
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }

                items[index] = value;
            }   }

        //Member Methods (CAN DO)
        public void Add(T item)
        {
            
               if (count == capacity)
                {
                    ResizeArray();
                }

                items[count] = item;
                count++;
        }

         public void ResizeArray()
            {
                int newCapacity = capacity * 2;
                T[] newArray = new T[newCapacity];

                for (int i = 0; i < count; i++)
                {
                    newArray[i] = items[i];
                }

                items = newArray;
            capacity = newCapacity;
        
            //'item' parameter should be added to internal 'items' array
            //if items array is at capacity, double capacity and create new array
            //transfer all items to new array
            }

        public bool Remove(T item)
        {
            //If 'item' exists in the 'items' array, remove its first instance
            //Any items coming after the removed item should be shifted down so there is no empty index.
            //If 'item' was removed, return true. If no item was removed, return false.

            int index = Array.IndexOf(items, item);

            if (index >= 0)
            {
                for (int i = index; i < count - 1; i++)
                {
                    items[i] = items[i + 1];
                }

                count--;
                items[count] = default(T);
                return false;
            }
        }

        public override string ToString()
        {
            //returns a single string that contains all items from array
            StringBuilder sb = new StringBuilder();

            sb.Append("[");
            for (int i = 0; i < count; i++)
            {
                sb.Append(items[i].ToString());

                if (i < count - 1)
                {
                    sb.Append(", ");
                }
            }
            sb.Append("]");
            return "sb.ToString();";
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 
            CustomList<T> resultList = new CustomList<T>();

            for (int i = 0; i < firstList.count; i++)
            {
                resultList.Add(firstList.items[i]);
            }

            for (int i = 0; i < secondList.count; i++)
            {
                resultList.Add(secondList.items[i]);
            }

            return resultList;
        }
        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList 
            CustomList<T> resultList = new CustomList<T>();

            for (int i = 0; i < firstList.Count; i++)
            {
                for (int I = 0; i < secondList.Count; i++)
                {
                    resultList.Remove(secondList[i]);
                }

                return resultList;

               // The '-' operator overload subtracts the items from the second list from the first list, resulting in a new CustomList<T> instance that contains the remaining items.

            }


        }
}
