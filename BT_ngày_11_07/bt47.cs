using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace bt47
{
    internal class Program
    {
        static void Main(string[] args)
        {
                // Khởi tạo một Dictionary mới
                Dictionary<string, int> myDictionary = new Dictionary<string, int>();

                // Thêm các phần tử vào Dictionary
                myDictionary.Add("Apple", 1);
                myDictionary.Add("Banana", 2);
                myDictionary.Add("Cherry", 3);

                // In ra các phần tử trong Dictionary
                foreach (KeyValuePair<string, int> kvp in myDictionary)
                {
                    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
                }
            }
        }
    }
