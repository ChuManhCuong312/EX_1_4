using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Vui lòng nhập một số thực: ");
        string input = Console.ReadLine();
        double number = double.Parse(input);
        int intNumber = (int)number;
        long longNumber = (long)number;
        Console.WriteLine($"Số bạn đã nhập là {number}, \ndưới dạng intNumber là {intNumber}, \ndưới dạng longNumber là {longNumber}.");
    }
}
