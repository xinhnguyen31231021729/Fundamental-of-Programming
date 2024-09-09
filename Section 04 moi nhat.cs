internal class Program
{
    private static void Main(string[] args)
    {
        //baitap_01();
        //baitap_02();
        //baitap_03();
        //baitap_04();
        //baitap_05();
        //baitap_06();
        //baitap_07();
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
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("The point is in the 4th quadrant");
        }

    }

    static void baitap_04()
    {
        Console.WriteLine("Nhap so do canh a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap so do canh b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap so do canh c: ");
        int c = int.Parse(Console.ReadLine());

        if (a == b && b == c)
        {
            Console.WriteLine("Tam giac deu");
        }
        else if (a == b || b == c || a == c)
        {
            Console.WriteLine("Tam giac can");
        }
        else
        {
            Console.WriteLine("Tam giac thuong");
        }
    }

    static void baitap_05()
    {
        double Sum = 0;
        int count = 10;

        Console.WriteLine("Please enter 10 numbers:");
        for (int i = 0; i < count; i++)
        {
            while (true)
            {
                try
                {
                    Console.Write($"Number {i + 1}: ");
                    double number = Convert.ToDouble(Console.ReadLine());
                    Sum += number;
                    break; 
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                }
            }
        }
        double average = Sum / count;

        Console.WriteLine("The sum of the 10 numbers is: {0}",Sum);
        Console.WriteLine("The average of the 10 numbers is: {0}",average);
    }

    static void baitap_06()
    {
        
            Console.Write("Nhap so nguyen de lap bang cuu chuong: ");

            int number;
            while (true)
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    break; 
                }
                catch (FormatException)
                {
                    Console.WriteLine("So khong hop le. Hay nhap so nguyen.");
                    Console.Write("Nhap so nguyen de lap bang cuu chuong: ");
                }
            }

            Console.WriteLine($"\nBang cuu chuong {number} la:\n");
            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} x {i} = {result}");
            }
    }

    static void baitap_07()
    {
        Console.WriteLine("Nhap so hang mong muon");
        int numberOfRows = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numberOfRows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }


}