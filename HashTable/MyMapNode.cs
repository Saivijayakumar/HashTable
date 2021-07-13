using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class MyMapNode<k, v>
    {
        public LinkedList<KeyValue<k, v>>[] item;
        public int size;
        public MyMapNode(int size)
        {
            this.size = size;
            this.item = new LinkedList<KeyValue<k, v>>[size];
        }
        public void Add(k key, v value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<k, v>> linkedList = GetLinkedlist(position);
            KeyValue<k, v> item = new KeyValue<k, v>() { key = key, value = value };
            linkedList.AddLast(item);
            Console.WriteLine(item.key + " " + item.value);
        }
        public int GetArrayPosition(k key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
        public LinkedList<KeyValue<k, v>> GetLinkedlist(int position)
        {
            LinkedList<KeyValue<k, v>> linkedList = item[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<k, v>>();
                item[position] = linkedList;
            }
            return linkedList;
        }


    }
    public struct KeyValue<k, v>
    {
        public k key;
        public v value;
    }
}
