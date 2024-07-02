/*
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LT4
{
    class array_float_2d
    {
        public static float[,] nhapmangfloat2d(int m,int n)
        {
            float[,] a = new float[m, n];
            if (a == null) return null;
            for(int i=0; i< m; i++)
            {
                Console.WriteLine("Nhập dòng thứ:" + (i + 1).ToString()+"/"+m.ToString() + " gồm " + n.ToString() + " số thực:");
                for (int j = 0; j < n; j++)
                    a[i, j] = EditNumbers.nhapsothuc4byte();
            }
            return a;
        }

        public static void hienthimangfloat2d(float[,] a)
        {
            if (a == null) return;
            
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j].ToString() + " ");
                }
                Console.Write("\n");
            }
        }

        public static void ghimang2dfloat_file_csv(float[,] a, string tenFile)
        {
            StreamWriter f = new StreamWriter(tenFile);
            {
                int rows = a.GetLength(0);
                int columns = a.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        f.Write(a[i, j]);

                        if (j < columns - 1)
                        {
                            f.Write(",");
                        }
                    }

                    f.WriteLine();
                }
                f.Dispose();
            }
        }

        public static float[,] docmang2dfloat_file_csv(string tenFile)
        {
            float[,] a;
            int columns;
            int rows;
            string line;
           
            
            StreamReader f = new StreamReader(tenFile);
            {
                line = f.ReadLine();
                columns = line.Split(',').Length;
                rows = 1;

                while (!f.EndOfStream)
                {
                    f.ReadLine();
                    rows++;
                }

                a = new float[rows, columns];

                f.BaseStream.Seek(0, SeekOrigin.Begin);

                for (int i = 0; i < rows; i++)
                {
                    line = f.ReadLine();
                    string[] values = line.Split(',');

                    for (int j = 0; j < columns; j++)
                    {
                        a[i, j] = float.Parse(values[j]);
                    }
                }
            }
            f.Dispose();
            
         
            string[] lines = File.ReadAllLines(tenFile);
            rows = lines.Length;
            columns = lines[0].Split(',').Length;

            a = new float[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(',');

                for (int j = 0; j < columns; j++)
                {
                      a[i, j] = float.Parse(values[j]);
                }
            }
           
            return a;
        }

    }
}
*/

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LT4
{
    class EditNumbers
    {
        public static int nhapsonguyenduong()
        {
            int n = 0;
            while (true)
            {
                try
                {
                    string sz;
                    sz = Console.ReadLine();
                    n = int.Parse(sz);
                    if (n > 0)
                        break;
                    else
                        Console.Beep();
                }
                catch
                {
                    Console.Beep();
                    
                }
            }//while
            return n;
        }// nhapsonguyenduong
        
        public static float nhapsothuc4byte()
        {
            float x = 0.0F;
            while (true)
            {
                try
                {
                    string sz;
                    sz = Console.ReadLine();
                    x = float.Parse(sz);
                    break;
                }
                catch
                {
                    Console.Beep();
                }
            }//while
            return x;
        }// nhapsothuc4byte
    }
}
*/

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LT4
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            Console.OutputEncoding = System.Text.Encoding.UTF8; // set encoding UTF-8 cho Console
            Console.WriteLine("Nhập số nguyên dương m:");
            m = EditNumbers.nhapsonguyenduong();
            Console.WriteLine("Nhập số nguyên dương n:");
            n = EditNumbers.nhapsonguyenduong();
            float x;
            Console.WriteLine("Nhập số thực x:");
            x = EditNumbers.nhapsothuc4byte();
            Console.WriteLine("m=" + m.ToString() + ",n=" + n.ToString() + ",x=" + x.ToString());

            float[,] a;
            a = array_float_2d.nhapmangfloat2d(m, n);
            if (a == null)
                Console.WriteLine("Không đủ bộ nhớ!");
            else
            {
                array_float_2d.hienthimangfloat2d(a);
                array_float_2d.ghimang2dfloat_file_csv(a, "a2d.csv");
                float[,] b = array_float_2d.docmang2dfloat_file_csv("a2d.csv");
                Console.WriteLine("Mảng đọc từ .csv là:");
                array_float_2d.hienthimangfloat2d(b);
            }//else
        }
    }
}
*/