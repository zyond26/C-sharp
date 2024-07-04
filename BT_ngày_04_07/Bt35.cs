using System;

// Lớp abstract Shape
public abstract class Shape
{
    protected int so_dinh { get; set; }

    // Constructor mặc định
    public Shape()
    {
        so_dinh = 0;
    }

    // Thuộc tính so_dinh có validation
    public int SoDinh
    {
        get { return so_dinh; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Số đỉnh phải lớn hơn 0");
            so_dinh = value;
        }
    }

    public abstract double TinhDienTich();
}

public class TamGiac : Shape
{
    public new int SoDinh
    {
        get { return base.so_dinh; }
        set
        {
            if (value != 3)
                throw new ArgumentException("Tam giác phải có 3 đỉnh");
            base.so_dinh = value;
        }
    }

    public TamGiac()
    {
        SoDinh = 3; // Mặc định tam giác có 3 đỉnh
    }

    public override double TinhDienTich()
    {
        return 0; // Thay đổi với công thức thực tế để tính diện tích tam giác
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Ví dụ sử dụng lớp TamGiac
        TamGiac tamGiac = new TamGiac();
        Console.WriteLine("Số đỉnh của tam giác: " + tamGiac.SoDinh);

        // Thử gán số đỉnh sai cho TamGiac
        try
        {
            tamGiac.SoDinh = 4; // Sẽ ném ngoại lệ vì số đỉnh phải là 3
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Lỗi: " + ex.Message);
        }

        // Thử gán số đỉnh sai cho Shape
        try
        {
            Shape shape = new Shape(); // Không thể khởi tạo Shape vì nó là abstract
            shape.SoDinh = 0; // Sẽ ném ngoại lệ vì số đỉnh phải lớn hơn 0
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Lỗi: " + ex.Message);
        }
    }
}
