using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; 
        Console.Write("Nhập số lượng phần tử trong mảng: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] numbers = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            Console.Write($"Nhập phần tử thứ {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int maxValue = numbers.Max();
        Console.WriteLine($"Giá trị lớn nhất trong mảng là {maxValue}");
    }
}
