
/////////////////////////////////////////// Bài tập 29. Đóng gói hàm vào 1 lớp.
// 29.a. Hãy chạy code sau:
using System;

class Program
{
    static void Main(string[] args)
    {
        double[] numbers = { 1.5, 2.7, 3.9, 4.2, 5.1 };

        double min = FindMin(numbers);
        double max = FindMax(numbers);

        Console.WriteLine("Min: " + min);
        Console.WriteLine("Max: " + max);
    }

    static double FindMin(double[] arr)
    {
        double min = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }

        return min;
    }

    static double FindMax(double[] arr)
    {
        double max = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        return max;
    }
}

//////29.b.Đóng gói(Encapsulation) các hàm FindMin(double[] arr), FindMax(double[] arr) trong 1 lớp array_double_1d và đặt trong cùng 1 file chứa hàm Main().
//Hãy chạy code sau:
//using System;

namespace C_btap29_ngày_02_07
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] numbers = { 1.5, 2.7, 3.9, 4.2, 5.1 };

            array_double_1d ob = new array_double_1d();
            double min = ob.FindMin(numbers);
            double max = ob.FindMax(numbers);

            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
        }
    }// Program

    public class array_double_1d
    {
        public double FindMin(double[] arr)
        {
            double min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            return min;
        }

        public double FindMax(double[] arr)
        {
            double max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}

////////////////////////////////////////29.c. Trong code b. trên, chuyển mảng đối của FindMin, FindMax về biến private của lớp.
//Khi đó các hàm FindMin, FindMax thành các hàm không đối. 
//Khai báo 1 biến mảng numbers kiểu private để làm biến truyền cho FindMin, FindMax.
//Viết hàm setNumbers để gán giá trị của biến numbers của lớp.
/*
using System;

namespace ex4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] numbers = { 1.5, 2.7, 3.9, 4.2, 5.1 };

            array_double_1d ob = new array_double_1d();
            ob.SetNumbers(numbers);
            double min = ob.FindMin();
            double max = ob.FindMax();

            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
        }
    }

    public class array_double_1d
    {
        private double[] numbers;

        public void SetNumbers(double[] arr)
        {
            numbers = arr;
        }

        public double FindMin()
        {
            double min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            return min;
        }

        public double FindMax()
        {
            double max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;
        }
    }
}

*/


////////////////////// 29.d. Tạo lại dự án để đặt lớp array_double_1d vào 1 file mới là array_double_1d.cs để dự án được tổ chức với nhiều file .cs.

/*
 * using System;

namespace C_btap29_ngày_02_07
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] numbers = { 1.5, 2.7, 3.9, 4.2, 5.1 };

            array_double_1d ob = new array_double_1d();
            ob.SetNumbers(numbers);
            double min = ob.FindMin();
            double max = ob.FindMax();

            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
        }
    }
    public class array_double_1d
    {
        private double[] numbers;

        public void SetNumbers(double[] arr)
        {
            numbers = arr;
        }

        public double FindMin()
        {
            double min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            return min;
        }

        public double FindMax()
        {
            double max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;
        }
    }
}
*/
