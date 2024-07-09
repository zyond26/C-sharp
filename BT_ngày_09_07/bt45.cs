using system;

public class GenericClass<T>
{
private T data;
public GenericClass(T value)
{ data = value; }
public T GetData()
{ return data; }
public void SetData(T value)
{ data = value; }
}
class Program
{
static void Main()
{
GenericClass<int> intInstance = new
GenericClass<int>(10);
Console.WriteLine(intInstance.GetData()
); // Output: 10
GenericClass<string> stringInstance =
new GenericClass<string>("Hello, World!");
Console.WriteLine(stringInstance.GetDat
a()); // Output: Hello, World!
}
}