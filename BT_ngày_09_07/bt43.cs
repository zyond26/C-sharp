public static void Swap<T>(ref a, ref b)
{
T temp =a;
a=b;
b = temp;
}
int a=5, b=7;
double c=3.4, d=2.5;
Swap<int>(ref a, ref b);
Swap<double>(ref c, ref d);