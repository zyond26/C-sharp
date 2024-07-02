using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_btap28_ngày_02_07
{
    public class class_demo
    {
        public void Show()
        {
            Console.WriteLine("Tôi là một lớp đơn giản!");
        }

        public ushort nhapsonguyen2bytekhongdau()
        {
            ushort n = 0;
            while (true)
            {
                try
                {
                    string sz;
                    sz = Console.ReadLine();
                    n = ushort.Parse(sz);
                    break;
                }
                catch
                {
                    Console.Beep();
                    // Console.WriteLine("...");
                }
            }
            return n;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            class_demo ob = new class_demo();
            ob.Show();
            ushort n;
            Console.WriteLine("Nhập n:");
            n = ob.nhapsonguyen2bytekhongdau();
            Console.WriteLine("n=" + n.ToString());
        }
    }
}
