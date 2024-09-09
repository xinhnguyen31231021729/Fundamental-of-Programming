
using System.Runtime.CompilerServices;

internal class Program
{
    static void Main(string[] args)
    {
        //int x = 5, y = 1, z = 10;

        //int m = max(x, y, z);
        //m = max(1);
        //Console.WriteLine(m);
        //m = max(1, 2);
        //Console.WriteLine(m);
        
        
        //Console.WriteLine("Enter a number: ");
        //int num = int.Parse(Console.ReadLine());
        //long f = factorial_recursion(num);
        //Console.WriteLine($"{num}! = {f}");

        int num = int.Parse(Console.ReadLine());
        bool f = isPrime(num);
        Console.WriteLine($"{num} is prime");
        
    }

    // bai tap 01
    //static int max(int a, int b, int c)
    //{
    // return Math.Max(Math.Max(a, b), c);
    //}

    //static int max(int a, params int[]args)
    //{
        //int m = a;
        //foreach (int i in args) // i la gia tri cua phan tu trong mang
        //{
           // if (i > m)
              //  m = i;
       // }
       // return Math.Max(a, m);
   // }


    
    //baitap04    
    //static long factorial(int n)//cach 1
        //{
            //long f = 1;
            //for (int i = 1; i <= n; i++)
                //f *= 1; 
           // return f;//f=1 nen return f la return tai 1
        //}

    //static long factorial_recursion(int n)//cach 2
    //{
        //if (n==0) return 1;// neu n=0 thì return ngay tại 1
       // return n * factorial_recursion(n-1);
    //}



    //bai tap 05
    static bool isPrime(int number)
    {
        for (int i = 2; i <= number / 2; i++)
            if (number % i == 0)
                return false;
        return true;
    }
}

