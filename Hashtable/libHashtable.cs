using libLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable
{

    public class libHashtable<K, V> : IlibHashtable<K, V>
    {
        private int m = 2;
        private int maxLengthLL;

        libArrayList.IArrayList<ILinkedList<Tuple<K, V>>> arrayList { get; set; }

        ILinkedList<Tuple<K, V>> linkedList { get; set; }

        public double Alpha
        {
            get
            {
                if (maxLengthLL == 0)
                    return 0;
                else
                    return (double)m / maxLengthLL;
            }
            private set { }
        }

        public libHashtable()
        {
            //Creates array with size of m-values
            arrayList = new libArrayList.ArrayList<ILinkedList<Tuple<K, V>>>(m);
            Alpha = 0;
        }
        /// <summary>
        /// Gets the Value of the key value pair of an specific key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public V get(K key)
        {
            int idx = getIndex(key);
            linkedList = arrayList[idx];

            if (linkedList == null)
            {
                Console.WriteLine("Not there");
                return default;
            }
            for (int i = 0; i < linkedList.length; i++)
            {
                if (key.Equals(linkedList.FindbyIndex(i).Item1))
                    return linkedList.FindbyIndex(i).Item2;
            }
            Console.WriteLine("Not there");
            return default;

        }
        /// <summary>
        /// Inserts a key value pair inside the hashtable
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void put(K key, V value)
        {
            Tuple<K, V> t = new Tuple<K, V>(key, value);

            linkedList = new libLinkedList.LinkedList<Tuple<K, V>>
                {
                    t
                };

            int idx = getIndex(key);
            //Checks if linkedlist at the specific index is already satisfied
            if (arrayList[idx] == null)
                arrayList[idx] = linkedList;
            else
            {
                linkedList = arrayList[idx];
                foreach (Tuple<K, V> item in linkedList)
                {
                    if (item == null)
                    {

                    }
                    else if (item.Item1.Equals(key))
                    {
                        linkedList.Remove(item);
                    };

                }
                linkedList.Add(t);

                if (maxLengthLL < linkedList.length)
                    maxLengthLL = linkedList.length;
            }
        }
        /// <summary>
        ///returns an index from the hash code.
        ///The amount and the modulo function are used to generate the index.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private int getIndex(K key)
        {
            return Math.Abs(key.GetHashCode() % m);
        }

        /// <summary>
        /// removes an element from linkedlist 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool remove(K key)
        {
            int idx = getIndex(key);
            linkedList = arrayList[idx];

            if (linkedList == null)
            {
                Console.WriteLine("Nothing to remove");
                return false;
            }

            for (int i = 0; i < linkedList.length; i++)
            {
                if (key.Equals(linkedList.FindbyIndex(i).Item1))
                {
                    linkedList.Remove(linkedList.FindbyIndex(i));
                    return true;
                }
            }
            return false;
        }
    }
}
