using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Vui lòng nhập một số nguyên: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        double doubleNumber = (double)number;
        Console.WriteLine($"Số bạn đã nhập là {number} và dưới dạng double là {doubleNumber}");
    }
}
