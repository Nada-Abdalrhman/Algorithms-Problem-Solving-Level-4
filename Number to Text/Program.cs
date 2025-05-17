using System.Linq;

namespace Number_to_Text;

class Program
{
    static void Main(string[] args)
    {
        // Problem One
        // Number to Text
        // NumToText(ReadNum("Enter a Number? "));
        PrintResult(ReadNum("Enter a Number? "));
        Console.ReadLine();
    }
    public static int ReadNum(string text)
    {
        Console.Write($"{text} ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }
    public static string NumToText(int num)
    {
        if (num == 0)
            return " ";
        if(num > 0 && num < 20)
        {
            string[] Numbers = { " ", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            return $"{Numbers[num]}";
        }
        if(num >= 20 && num <= 99)
        {
            string[] Numbers = { " ", " ", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            return $"{Numbers[num / 10]} {NumToText(num % 10)}";
        }
        if(num >= 100 && num <= 199)
        {
            return $"One Hundred {NumToText(num % 100)}";
        }
        if(num >= 200 && num <= 999)
        {
            return $"{NumToText(num / 100)} Hundreds {NumToText(num % 100)}";
        }
        if (num >= 1000 && num <= 1999)
        {
            return $"One Thousand {NumToText(num % 1000)}";
        }
        if (num >= 2000 && num <= 999999)
        {
            return $"{NumToText(num / 1000)} Thousands {NumToText(num % 1000)}";
        }
        if (num >= 1000000 && num <= 1999999)
        {
            return $"One Million {NumToText(num % 1000000)}";
        }
        if (num >= 2000000 && num <= 999999999)
        {
            return $"{NumToText(num / 1000000)} Millions {NumToText(num % 1000000)}";
        }
        if (num >= 1000000000 && num <= 1999999999)
        {
            return $"One Billion {NumToText(num % 1000000)}";
        }
        else
        {
            return $"{NumToText(num / 1000000000)} Billions {NumToText(num % 1000000000)}";
        }
    }
    public static void PrintResult(int num)
    {
        Console.WriteLine(NumToText(num));
    }
}

