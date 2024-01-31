//using System;

//namespace FCS_HSE;
//class Program
//{
//    static void Main(string[] args)
//    {
//        do
//        {
//            Console.Clear();
//            Self2_1(); // MAIN MAIN MAIN MAIN MAIN MAIN MAIN MAIN MAIN MAIN MAIN MAIN MAIN MAIN MAIN MAIN MAIN MAIN MAIN MAIN MAIN MAIN
//            Console.WriteLine();
//            Console.WriteLine("Нажмите Escape, чтобы завершить программу, или любую другую клавишу, чтобы перезапустить её");
//        }
//        while (Console.ReadKey().Key != ConsoleKey.Escape);
//    }
//    public static void Self1()
//    {
//        Console.Write("n = ");
//        int n = int.Parse(Console.ReadLine());
//        int[] array = new int[n];
//        for (int i = 0; i < n; ++i)
//        {
//            Console.Write("x = ");
//            int x = int.Parse(Console.ReadLine());
//            array[i] = x;
//        }
//        foreach (int i in array)
//        {
//            Console.Write(i);
//            Console.Write(' ');
//        }
//        Console.WriteLine();
//    }
//    public static void Self2()
//    {
//        Console.Write("n = ");
//        int n = int.Parse(Console.ReadLine());
//        int[] array = new int[n];
//        for (int i = 0; i < n; ++i)
//        {
//            Random rnd = new Random();
//            int x = rnd.Next(-2, 8);
//            array[i] = x;
//        }
//        foreach (int i in array)
//        {
//            Console.Write(i);
//            Console.Write(' ');
//        }
//        Console.WriteLine();
//    }
//    public static void Self3()
//    {
//        Console.Write("n = ");
//        int n = int.Parse(Console.ReadLine());
//        int[] array = new int[n];
//        for (int i = 0; i < n; ++i)
//        {
//            Random rnd = new Random();
//            int x = rnd.Next(-2, 8);
//            array[i] = x;
//        }
//        Array.Sort(array);
//        Array.Reverse(array);
//        foreach (int i in array)
//        {
//            Console.Write(i);
//            Console.Write(' ');
//        }
//        Console.WriteLine();
//    }
//    public static void Self4()
//    {
//        Console.Write("n = ");
//        int n = int.Parse(Console.ReadLine());
//        int[] array = new int[n];
//        int cnt2 = 0;
//        int cnt1 = 0;
//        Random rnd = new Random();
//        for (int i = 0; i < n; ++i)
//        {
//            int x = rnd.Next(-2, 8);
//            array[i] = x;
//            if (x % 2 == 0)
//            {
//                cnt2++;
//            }
//            else
//            {
//                cnt1++;
//            }
//        }
//        int j = 0;
//        int g = 0;
//        int[] array1 = new int[cnt1];
//        int[] array2 = new int[cnt2];
//        for (int i = 0; i < array.Length; ++i)
//        {
//            if (array[i] % 2 == 0)
//            {
//                array2[j] = array[i];
//                ++j;
//            }
//            else
//            {
//                array1[g] = array[i];
//                ++g;
//            }
//        }
//        foreach (int i in array)
//        {
//            Console.Write(i);
//            Console.Write(' ');
//        }
//        Console.WriteLine();
//        foreach (int i in array1)
//        {
//            Console.Write(i);
//            Console.Write(' ');
//        }
//        Console.WriteLine();
//        foreach (int i in array2)
//        {
//            Console.Write(i);
//            Console.Write(' ');
//        }
//        Console.WriteLine();
//    }
//    public static void Self5()
//    {
//        Console.Write("n = ");
//        int n = int.Parse(Console.ReadLine());
//        int[] array = new int[n];
//        Random rnd = new Random();
//        for (int i = 0; i < n; ++i)
//        {
//            int x = rnd.Next(1, 6);
//            array[i] = x;
//        }
//        int cnt1 = 0, cnt2 = 0, cnt3 = 0, cnt4 = 0, cnt5 = 0;
//        foreach (int i in array)
//        {
//            Console.Write(i);
//            Console.Write(' ');
//        }
//        Console.WriteLine();
//        for (int i = 0; i < array.Length; ++i)
//        {
//            int x = array[i];
//            if (x == 1)
//            {
//                cnt1++;
//                if (cnt1 > 1)
//                {
//                    array[i] = 0;
//                }
//            }
//            else if (x == 2)
//            {
//                cnt2++;
//                if (cnt2 > 1)
//                {
//                    array[i] = 0;
//                }
//            }
//            else if (x == 3)
//            {
//                cnt3++;
//                if (cnt3 > 1)
//                {
//                    array[i] = 0;
//                }
//            }
//            else if (x == 4)
//            {
//                cnt4++;
//                if (cnt4 > 1)
//                {
//                    array[i] = 0;
//                }
//            }
//            else if (x == 5)
//            {
//                cnt5++;
//                if (cnt5 > 1)
//                {
//                    array[i] = 0;
//                }
//            }
//        }
//        foreach (int i in array)
//        {
//            Console.Write(i);
//            Console.Write(' ');
//        }
//        Console.WriteLine();
//    }
//    public static void Self6()
//    {
//        Console.Write("x = ");
//        string x = Console.ReadLine();
//        x = x[1..^1];
//        Console.WriteLine(x);
//        Console.WriteLine($"count = {x.Length}");
//    }
//    public static void Self7()
//    {
//        int[] a = new int[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
//        int[] b = new int[10];
//        Random rnd = new Random();
//        for (int i = 0; i < b.Length; ++i)
//        {
//            b[i] = rnd.Next(-12, 15);
//        }
//        int cnt2 = 0;
//        foreach (int i in a)
//        {
//            Console.Write(i);
//            Console.Write(' ');
//            if (i % 2 == 0)
//            {
//                cnt2++;
//            }
//        }
//        Console.WriteLine();
//        foreach (int i in b)
//        {
//            Console.Write(i);
//            Console.Write(' ');
//        }
//        Console.WriteLine();
//        int[] c = new int[b.Length + cnt2];
//        int j = 0;
//        for (int i = 0; i < b.Length; ++i)
//        {
//            c[i] = b[i];
//            j = i + 1;
//        }
//        for (int i = 0; i < a.Length; ++i)
//        {
//            if (a[i] % 2 == 0)
//            {
//                c[j] = a[i];
//                j++;
//            }
//        }
//        foreach (int i in c)
//        {
//            Console.Write(i);
//            Console.Write(' ');
//        }
//    }
//    public static void Self8()
//    {
//        Console.Write("n = ");
//        int n = int.Parse(Console.ReadLine());
//        double[] arr = new double[n];
//        double x = 2;
//        for (int i = 0; i < n; i++)
//        {
//            arr[i] = Math.Pow(2, i);
//        }
//        foreach (int i in arr)
//        {
//            Console.Write(i);
//            Console.Write(' ');
//        }
//    }
//    public static void Self9()
//    {
//        Console.Write("n = ");
//        int n = int.Parse(Console.ReadLine());
//        int[] arr = new int[n];
//        int j = 1;
//        for (int i = 0; i < n; ++i)
//        {
//            arr[i] = j;
//            j += 2;
//        }
//        foreach (int i in arr)
//        {
//            Console.Write(i);
//            Console.Write(' ');
//        }
//    }
//    public static void Self10()
//    {
//        Console.Write("n = ");
//        int n = int.Parse(Console.ReadLine());
//        Console.Write("a = ");
//        int a = int.Parse(Console.ReadLine());
//        Console.Write("d = ");
//        int d = int.Parse(Console.ReadLine());
//        int[] arr = new int[n];
//        for (int i = 0; i < n; ++i)
//        {
//            arr[i] = a + i * d;
//        }
//        foreach (int i in arr)
//        {
//            Console.Write(i);
//            Console.Write(' ');
//        }
//    }
//    public static void Self11()
//    {
//        Console.Write("n = ");
//        int n = int.Parse(Console.ReadLine());
//        int[] arr = new int[n];
//        for (int i = 0; i < n; ++i)
//        {
//            if (i == 0)
//            {
//                arr[i] = 1;
//            }
//            else if (i == 1)
//            {
//                arr[i] = 1;
//            }
//            else
//            {
//                arr[i] = arr[i - 1] + arr[i - 2];
//            }
//        }
//        foreach (int i in arr)
//        {
//            Console.Write(i);
//            Console.Write(' ');
//        }
//    }
//    public static void Self1_1()
//    {
//        Console.Write("n = ");
//        int n = int.Parse(Console.ReadLine());
//        double[] arr = new double[n];
//        Random rnd = new Random();
//        for (int i = 0; i < n; ++i)
//        {
//            double x = -4.5 + rnd.NextDouble() * (4.5 - (-4.5));
//            arr[i] = Math.Round(x, 3);
//        }
//        foreach (var i in arr)
//        {
//            Console.Write(i);
//            Console.Write(' ');
//        }
//    }
//    public static void Self1_2()
//    {
//        static bool TryFindMaxElement(double[] array, out double maxValue)
//        {
//            maxValue = 0;
//            if (array == null || array.Length == 0)
//            {
//                return false;
//            }
//            foreach (var i in array)
//            {
//                if (maxValue < i)
//                {
//                    maxValue = i;
//                }
//            }
//            return true;
//        }
//        Console.Write("n = ");
//        int n = int.Parse(Console.ReadLine());
//        double[] arr = new double[n];
//        Random rnd = new Random();
//        for (int i = 0; i < n; ++i)
//        {
//            double x = -4.5 + rnd.NextDouble() * (4.5 - (-4.5));
//            arr[i] = Math.Round(x, 3);
//        }
//        TryFindMaxElement(arr, out double maxValue);
//        Console.WriteLine(maxValue);
//        foreach (var i in arr)
//        {
//            Console.Write(i);
//            Console.Write(' ');
//        }
//    }
//    public static void Self1_4()
//    {
//        static void f1(in int[] arr1, ref int[] arr2)
//        {
//            if (arr1 == null || arr1.Length == 0)
//            {
//                return;
//            }
//            else if (arr2 == null || arr2.Length == 0)
//            {
//                arr2 = new int[arr1.Length];
//            }
//            foreach (int i in arr1)
//            {
//                if (i % 2 == 0)
//                {
//                    Array.Resize(ref arr2, arr2.Length + 1);
//                    arr2[^1] = i;
//                }
//            }
//        }
//        Console.Write("n1 = ");
//        int n1 = int.Parse(Console.ReadLine());
//        Console.Write("n2 = ");
//        int n2 = int.Parse(Console.ReadLine());
//        int[] arr1 = new int[n1];
//        int[] arr2 = new int[n2];
//        Random rnd = new Random();
//        for (int i = 0; i < arr1.Length; ++i)
//        {
//            arr1[i] = rnd.Next(-100, 101);
//        }
//        for (int i = 0; i < arr2.Length; ++i)
//        {
//            arr2[i] = rnd.Next(-100, 101);
//        }
//        f1(arr1, ref arr2);
//        foreach (var i in arr1)
//        {
//            Console.Write(i);
//            Console.Write(' ');
//        }
//        Console.WriteLine();
//        foreach (var i in arr2)
//        {
//            Console.Write(i);
//            Console.Write(' ');
//        }
//    }
//    public static void Self1_5()
//    {
//        static void f(ref int[] arr1, out int[] arr2)
//        {
//            int cnt = 0;
//            for (int i = 0; i < arr1.Length; ++i)
//            {
//                if (arr1[i] < 0)
//                {
//                    cnt++;
//                }
//            }
//            arr2 = new int[cnt];
//            int[] arr3 = new int[arr1.Length - cnt];
//            int j = 0;
//            int h = 0;
//            for (int i = 0; i < arr1.Length; ++i)
//            {
//                if (arr1[i] < 0)
//                {
//                    arr2[j] = arr1[i];
//                    j++;
//                }
//                else
//                {
//                    arr3[h] = arr1[i];
//                    h++;
//                }
//            }
//            arr1 = arr3;
//        }
//        Console.Write("n = ");
//        int n = int.Parse(Console.ReadLine());
//        int[] arr = new int[n];
//        for (int i = 0; i < n; ++i)
//        {
//            Console.Write("x = ");
//            int x = int.Parse(Console.ReadLine());
//            arr[i] = x;
//        }
//        Console.WriteLine();
//        f(ref arr, out int[] arr2);
//        foreach (var i in arr)
//        {
//            Console.Write(i);
//            Console.Write(' ');
//        }
//        Console.WriteLine();
//        foreach (var i in arr2)
//        {
//            Console.Write(i);
//            Console.Write(' ');
//        }
//    }
//    public static void Self1_6()
//    {
//        Console.Write("n = ");
//        int n = int.Parse(Console.ReadLine());
//        int[] arr = new int[n];
//        Random rnd = new Random();
//        for (int i = 0; i < n; ++i)
//        {
//            int x = rnd.Next(-100, 101);
//            arr[i] = x;
//        }
//        foreach (var i in arr)
//        {
//            Console.Write(i);
//            Console.Write(' ');
//        }
//        Console.WriteLine();
        
//        foreach (var i in arr)
//        {
//            Console.Write(i);
//            Console.Write(' ');
//        }
//        static void f(ref int[] arr)
//        {
//            for (int i = 0; i < arr.Length - 1; ++i)
//            {
//                if ((arr[i] + arr[i + 1]) % 3 == 0)
//                {
//                    arr[i] = arr[i] * arr[i + 1];
//                }
//            }
//        }
//    }
//    public static void Self2.1()
//}

using System;
using System.Text;

/// <summary> 
/// Class for rectangle 
/// </summary> 
public class Rectangle
{
    private double _height;
    private double _width;

    /// <summary> 
    ///  
    /// </summary> 
    /// <param name="height"></param> 
    /// <param name="width"></param> 
    public Rectangle(double height = 1, double width = 1)
    {
        Height = height;
        Width = width;
    }

    /// <summary> 
    ///  
    /// </summary> 
    public double Height
    {
        get => _height;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height can't be < 0");
            }

            _height = value;
        }
    }

    /// <summary> 
    ///  
    /// </summary> 
    public double Width
    {
        get => _width;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width can't be < 0");
            }

            _width = value;
        }
    }

    /// <summary> 
    ///  
    /// </summary> 
    public double Perimeter
    {
        get => 2 * (Height + Width);
    }

    /// <summary> 
    ///  
    /// </summary> 
    public double Area
    {
        get => Width * Height;
    }

    /// <summary> 
    ///  
    /// </summary> 
    /// <returns></returns> 
    public override string ToString()
    {
        StringBuilder builder = new();
        builder.Append($"Height {Height};\n");
        builder.Append($"Width {Width};\n");
        builder.Append($"Perimeter {Perimeter};\n");
        builder.Append($"Area {Area};\n");

        return builder.ToString();
    }
}

public class Program
{

    /// <summary> 
    ///  
    /// </summary> 
    /// <param name="n"></param> 
    /// <param name="entery"></param> 
    static void ReadDouble(out double n, string entery)
    {
        System.Console.Write(entery);
        while (!double.TryParse(Console.ReadLine(), out n))
        {
            System.Console.WriteLine("Incorrect number");
        }
    }

    public static void Main()
    {
        double height, width;
        ReadDouble(out height, "Enter height: ");
        ReadDouble(out width, "Enter width: ");

        try
        {
            Rectangle r = new();
            Rectangle rectangle = new(height, width);
            Console.WriteLine(rectangle);
        }
        catch (ArgumentException err)
        {
            Console.WriteLine(err.Message);
        }
        catch
        {
            Console.WriteLine("Undefined behavior.");
        }
    }
}
