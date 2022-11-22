using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable
{
    public interface IlibHashtable<K, V>
    {
        void put(K key, V Value);

        V get(K key);

        bool remove(K key);

        double Alpha { get; }
    }
}
