using System.Drawing;

class Program
{
    private static void Main(string[] args)
    {
        //baitap_01();
        //baitap_02();
        //baitap_03();
        baitap_04();
    }


    static void baitap_01()
    {
        Console.WriteLine("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine("It's an even number.");
        }
        else
        {
            Console.WriteLine("It's an odd number.");
        }
    }

    static void baitap_02()
    {
        Console.WriteLine("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number: ");
        int num3 = int.Parse(Console.ReadLine());

        if ((num1 > num2) && (num1 > num3))
        {
            Console.WriteLine("The largest number is: {0}", num1);
        }
        else if (num2 > num3)
        {
            Console.WriteLine("The largest number is: {0}", num2);
        }
        else
        {
            Console.WriteLine("The largest number is: {0}", num3);
        }
    }

    static void baitap_03()
    {
        Console.WriteLine("Enter x: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter y: ");
        int y = int.Parse(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine("The point is in the 1st quadrant");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("The point is in the 2nd quadrant");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("The point is in the 3rd quadrant");
        }
        else if(x > 0 && y < 0)
        {
            Console.WriteLine("The point is in the 4th quadrant");
        }

    }

    static void baitap_04()
    {
        Console.WriteLine("Nhập số đo cạnh a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhập số đo cạnh b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhập số đo cạnh c: ");
        int c = int.Parse(Console.ReadLine());

        if(a>b&& b>c)

    }
}