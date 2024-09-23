using System.ComponentModel;
using System.Drawing;
using System.Security.Cryptography;

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
        //baitap_08();
        //baitap_09();
        baitap_10();
    }


    static void baitap_01()
    // Write a C# Sharp program to check whether a given number is even or odd.
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
    // Write a C# Sharp program to find the largest of three numbers.
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
    // Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
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
    // Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
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
    // Write a program to read 10 numbers and find their average and sum.

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

        Console.WriteLine("The sum of the 10 numbers is: {0}", Sum);
        Console.WriteLine("The average of the 10 numbers is: {0}", average);
    }

    static void baitap_06()
    // Write a program to display the multiplication table of a given integer.
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
    // Write a program to display a pattern like triangles with a number.
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


    static void baitap_08()
    // Write a program to display the n terms of harmonic series and their sum. 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms
    {
        Console.WriteLine("Enter the terms of harmonic series: n = ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0.0;

        Console.Write("Harmonic series: ");

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("1/{0} ", i);
            if (i < n)
                Console.WriteLine("+ ");
            sum += 1.0 / i;

        }
        Console.WriteLine($"\nSum of the harmonic series up to {n} terms: {sum}");
    }

    static void baitap_09()
    // Write a program to find the ‘perfect’ numbers within a given number range.
    {
        Console.WriteLine("Enter the lower bound of the average: ");
        int lower = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the upper bound of the average: ");
        int upper = int.Parse(Console.ReadLine());
        Console.WriteLine("Perfect numbers between {0} and {1} are: ", lower, upper);

        for (int num = lower; num <=upper; num++)
        {
            //if (Perfectnumber(num))
            {
                Console.WriteLine(num);
            }    
        }  
    }

    static bool Perfectnumber(int number)
    {
        int sum = 0;

        //find the sum of divisors
        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }

        //a perfect number is equal to the sum of ít proper divisors
        return sum == number && number != 0;
    }


    static void baitap_10()
    // Write a program to determine whether a given number is prime or not.
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPrime(number))
        {
            Console.WriteLine($"{number} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a prime number.");
        }
    }

    static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }
}