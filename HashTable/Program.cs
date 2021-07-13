using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        /// <summary>
        /// --------------------->Welcome To Hash Table<-----------------
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---------------->Welcome To Hash Table<-----------------");

            MyMapNode<int, string> hashTable = new MyMapNode<int, string>(6);
            hashTable.Add(0, "To");
            hashTable.Add(1, "be");
            hashTable.Add(2, "or");
            hashTable.Add(3, "not");
            hashTable.Add(4, "to");
            hashTable.Add(5, "be");
            Console.ReadLine();
        }
    }
}
