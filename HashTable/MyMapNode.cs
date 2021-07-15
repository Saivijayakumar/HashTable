using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class MyMapNode<K, V>
    {
        public LinkedList<KeyValue<K, V>>[] item;
        public int size;
        public MyMapNode(int size)
        {
            this.size = size;
            this.item = new LinkedList<KeyValue<K, V>>[size];
        }
        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedlist(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { key = key, value = value };
            linkedList.AddLast(item);
        }
        public int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
        public LinkedList<KeyValue<K, V>> GetLinkedlist(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = item[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                item[position] = linkedList;
            }
            return linkedList;
        }
        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.key.Equals(key))
                {
                    return item.value;
                }
            }
            return default(V);
        }
        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = item[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                item[position] = linkedList;
            }
            return linkedList;
        }
        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            bool itemFound = false;
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                linkedList.Remove(foundItem);
            }
        }
        public void Display()
        {
            foreach(var linkedList in item)
            {
                if(linkedList != null)
                    foreach(var element in linkedList)
                    {
                        string res = element.ToString();
                        if(res != null)
                            Console.WriteLine(element.key +" "+element.value);
                    }
            }
        }
    }
    public struct KeyValue<K, V>
    {
        public K key;
        public V value;
    }
}
