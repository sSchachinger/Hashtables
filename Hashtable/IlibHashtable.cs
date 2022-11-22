using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable
{
    public interface IlibHashtable<K, V>
    {
        /// <summary>
        /// Inserts a key value pair inside the hashtable
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        void put(K key, V Value);

        /// <summary>
        /// Gets the Value of the key value pair of an specific key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        V get(K key);

        /// <summary>
        /// removes an element from linkedlist 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        bool remove(K key);
        /// <summary>
        /// Occupancy factor
        /// </summary>
        double Alpha { get; }

        /// <summary>
        /// Check if Hashtable Contains specific value
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        bool Contains(Tuple<K, V> tuple);

    }
}
