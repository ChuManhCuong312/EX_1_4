using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Vui lòng nhập một ký tự: ");
        char inputChar = Console.ReadKey().KeyChar;
        Console.WriteLine();  // Chuyển xuống dòng mới
        int asciiCode = (int)inputChar;
        Console.WriteLine($"Ký tự bạn đã nhập là '{inputChar}', mã ASCII của nó là {asciiCode}");
    }
}
