using System;

namespace Bai_so07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap number: ");
            int number = int.Parse(Console.ReadLine());
            switch(number) {
                case 0:
                    //a. Viết một chương trình nhận vào hai số nguyên không dấu từ người dùng và tính tổng của chúng.
                    int a, c;
                    Console.WriteLine("nhap a: ");
                    a= int.Parse(Console.ReadLine());
                    Console.WriteLine("nhap c: ");
                    c = int.Parse(Console.ReadLine());
                    Console.WriteLine("tong 2 so: " + (a + c));
                    break;
                case 1:
                    //b. Viết một chương trình nhận vào chiều dài và chiều rộng của một hình chữ nhật từ người dùng là số nguyên 2 byte không dấu.
                    //Tính diện tích và chu vi của hình chữ nhật đó. 
                    int length, width;
                    Console.WriteLine("nhap length: ");
                    length = int.Parse(Console.ReadLine());
                    Console.WriteLine("nhap width: ");
                    width = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dien tich cua hcn: "+(length*width));
                    Console.WriteLine("Chu vi cua hcn: "+((length+width)*2));
                    break;
                case 2:
                    //c. Viết một chương trình nhận vào một số nguyên không dấu  4byte từ người dùng và kiểm tra xem số đó là chẵn hay lẻ.
                    int n;
                    Console.WriteLine("nhap n: ");
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0) {
                        Console.WriteLine("n la so chan");
                    }
                     else Console.WriteLine("n la so le");
                    break;
                case 3:
                    // d.Viết một chương trình nhận vào hai số nguyên có dấu 1byte từ người dùng và tính tổng của chúng.
                    int b, d;
                    Console.WriteLine("nhap b: ");
                    b= int.Parse(Console.ReadLine());
                    Console.WriteLine("nhap d: ");
                    d = int.Parse(Console.ReadLine());
                    Console.WriteLine("tong 2 so: "+(b+d));
                    break;  
                case 4:
                    //e. Viết một chương trình nhận vào một số nguyên n không dấu 4byte từ người dùng và tính tổng của các số từ 1 đến n. 
                    int m ;
                    Console.WriteLine("nhap m: ");
                    m = int.Parse(Console.ReadLine());
                    int sum = 0;
                    for (int e = 1; e <= m; e++)
                    {
                        sum += e;
                    }
                    Console.WriteLine("tong cac so tu 1 den n la: "+sum);
                    break;
                case 5:
                    //g. Viết một chương trình nhận vào chiều dài và chiều rộng kiểu số thwucj 8 byte của một hình chữ nhật từ người dùng. 
                    // Tính diện tích và chu vi của hình chữ nhật đó.
                    int dai, rong;
                    Console.WriteLine("nhap chieu dai: ");
                    dai = int.Parse(Console.ReadLine());
                    Console.WriteLine("nhap chieu rong: ");
                    rong = int.Parse(Console.ReadLine());
                    Console.WriteLine("dtich hcn: " + (dai * rong));
                    Console.WriteLine("chu vi hcn: " + ((dai + rong) * 2));
                    break;
                case 6:
                    //h. Viết một chương trình nhận vào ba số nguyên từ người dùng và tìm số lớn nhất trong ba số đó.
                    int i, j, k;
                    Console.WriteLine("nhap i,j,k: ");
                    i = int.Parse(Console.ReadLine());
                    j = int.Parse(Console.ReadLine());
                    k = int.Parse(Console.ReadLine());
                    int max = i;
                    if (j > max)
                    {
                        max = j;
                    }
                    if (k > max)
                    {
                        k = max;
                    }
                    Console.WriteLine("so lon nhat trong 3 so la: "+ max);
                    break;
                case 7:
                    //k. Viết một chương trình nhận vào một số nguyên không âm n từ người dùng và tính giai thừa của số đó. 
                    int num;
                    Console.WriteLine("nhap num: ");
                    num = int.Parse(Console.ReadLine());
                    long factorial = 1;
                    for (int h = 2; h <= num; h++)
                    {
                        factorial *= h;
                    }
                    Console.WriteLine("gia thua cua num la: "+factorial);
                    break;
                case 8:
                    //l. Viết một chương trình nhận vào một số nguyên n từ người dùng và kiểm tra xem số đó có phải là số nguyên tố hay không.
         
                Console.Write("Nhập một số nguyên không âm q: ");
                int q;
                q = int.Parse(Console.ReadLine());
                    bool isPrime = true;
                    if (q <= 1)
                    {
                        isPrime = false;
                    }
                    else
                    {
                        for (int l = 2; l <= Math.Sqrt(q); l++)
                        {
                            if (l % q == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                    }
                    // Hiển thị kết quả
                    if (isPrime)
                    {
                        Console.WriteLine($"{q} la snt.");
                    }
                    else
                    {
                        Console.WriteLine($"{q} khong la snt.");
                    }
                    break;
                case 9:
                    //m. Viết một chương trình nhận vào một số nguyên từ người dùng và kiểm tra xem số đó có phải là số hoàn hảo hay không.
                    // Số hoàn hảo là số mà tổng các ước số của nó(không tính chính nó) bằng chính nó
                    int t;
                    Console.WriteLine("nhap t: ");
                    t = int.Parse(Console.ReadLine());                  
                    // Tính tổng các ước số của số đó
                    int tong = 0;
                    for (int u = 1; u < t; u++)
                    {
                        if (t% u == 0)
                        {
                            tong += u;
                        }
                    }

                    // Kiểm tra xem số đó có phải là số hoàn hảo hay không
                    bool isPerfect = (tong == t);

                    // Hiển thị kết quả
                    if (isPerfect)
                    {
                        Console.WriteLine($"{t} la so hoan hao");
                    }
                    else
                    {
                        Console.WriteLine($"{t} khong phai la so hoan hao");
                    }
                    break;
            }
        }
}
}
