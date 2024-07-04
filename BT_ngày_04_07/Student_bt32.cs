// Student.cs
public class Student : Person, KPI
{
    public string Major { get; set; }

    public void kpi()
    {
        // Implementation of the KPI method
        Console.WriteLine($"KPI for student {Name} in major {Major}");
    }
}
