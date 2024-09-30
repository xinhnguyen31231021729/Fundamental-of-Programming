using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*Viết chương trình bao gồm các hàm sau:
1. Phát sinh một mảng có N số nguyên ngẫu nhiên, với N nhập từ bàn phím.
2. In ra mảng này.
3. Nhập một số X, tìm xem số X có tồn tại trong mảng hay không.Nếu có trả về vị trí xuất hiện
sau cùng của X, không có thì trả về -1.
4. In ra các phần tử trong mảng là số nguyên tố.
5. Kiểm tra 1 mảng đã được sắp xếp chưa. Nếu có thì trả về true, còn không trả về false.
6. Sắp xếp các phần tử mảng theo thứ tự giảm dần (không dung hàm do C# cung cấp sẵn)
7. Viết một hàm phát sinh ngẫu nhiên một ma trận chữ nhật NxM, với N, M nhập từ bàn phím.
8. In ma trận đã nhập.
9. Nhập vào 1 giá trị chỉ cột, hãy tính tổng các phần tử thuộc cột đó.
10. Viết một menu cho phép lựa chọn các hàm và thực thi.*/


    internal class NguyenThanhXinh_31231021729
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the no rows: ");
            int[] numbers = random_array();
            Print_array(numbers);
            int rows = int.Parse(Console.ReadLine());
            int[][] a = new int[rows][];
            init_random(a, rows);
            while (true)
            {
                int sel = menu();
                switch (sel)
                {
                    case 0:
                        Console.WriteLine("bye"); return;
                    case 1:
                        random_array(a,rows); break;
                    case 2: init_random(a, rows); break;
                }
                    Console.WriteLine("Enter a number for searching: ");
                int num = int.Parse(Console.ReadLine());
                search_and_print(a, num);
                break;               
            }

        }

        static void random_array(int[] arg)
        {
            Console.WriteLine("Enter the number of the array size: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(1, 50);
            }
        }


        static int[] Print_array(int[] array)
        {
            for (int i = 0; i <= array.Length; i++) ;
            {
                Console.WriteLine(array[i] + " ");
            }
            return array;
        }

        static bool isPrime(int n)
        {

        }
        static void Print_prime(int[] array)
        {
            for (int i = 0;i<= array.Length; i++)
            if isPrime
        }

        static void print(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                    Console.WriteLine(a[i][j] + "\t");
                Console.WriteLine();
            }
        }

                static void search_and_print(int[] a, int val)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j <= a.Length; j++)
                    if (a[i][j] == val)
                        Console.WriteLine($"{{val}} appears at row [{{i}}], ccol[{{j}}]");
            }           
        }



        static int menu()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("\t\t jagged array demo\n");
            Console.WriteLine("1. Jagged array init");
            Console.WriteLine("2. Print array");
            Console.WriteLine();
            Console.WriteLine("Your select <1..6>");
            int sel = 0;
            while (true)
            {
                bool c = int.TryParse(Console.ReadLine(), out sel);
                if (c && sel >= 0 && sel <= 2)
                    break;
                else
                    Console.WriteLine("Please enter a valid choice");
            }
            return sel;
        }


        static void array_random(int n)
        {
            Console.WriteLine("Nhap N so nguyen cua mang: ");
            
        }
        
        static void init_random(int[][] a, int rows)
        //Viết một hàm phát sinh ngẫu nhiên một ma trận chữ nhật NxM, với N, M nhập từ bàn phím.
        {
            Console.WriteLine("Nhap so hang n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot m: ");
            int m = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {            
                int cols = rnd.Next(n,m);
                a[i]=new int[cols];
                for (int j = 0; j < cols; j++)
                    a[i][j] = rnd.Next(10, 50);
            }
        }

    }
}
