using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace JsonFileOperations
{
    // Bước 1: Định nghĩa lớp Product
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string jsonFilePath = "products.json";

            // Tạo danh sách các đối tượng Product mẫu
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 1000.00m, Category = "Electronics" },
                new Product { Id = 2, Name = "Smartphone", Price = 500.00m, Category = "Electronics" },
                new Product { Id = 3, Name = "Table", Price = 150.00m, Category = "Furniture" }
            };

            // Ghi danh sách sản phẩm vào tệp JSON
            WriteProductsToJson(jsonFilePath, products);

            // Đọc danh sách sản phẩm từ tệp JSON
            List<Product> productsFromJson = ReadProductsFromJson(jsonFilePath);

            // Hiển thị danh sách sản phẩm từ tệp JSON
            foreach (var product in productsFromJson)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Category: {product.Category}");
            }
        }

        // Bước 2: Phương thức đọc dữ liệu từ tệp JSON và chuyển đổi thành danh sách các đối tượng Product
        static List<Product> ReadProductsFromJson(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            List<Product> products = JsonSerializer.Deserialize<List<Product>>(jsonString);
            return products;
        }

        // Bước 3: Phương thức ghi danh sách các đối tượng Product vào tệp JSON
        static void WriteProductsToJson(string filePath, List<Product> products)
        {
            string jsonString = JsonSerializer.Serialize(products, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonString);
        }
    }
}
