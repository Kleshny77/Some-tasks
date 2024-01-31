namespace hse;
using System;
class Program
{
    static void Main()
    {
        do
        {
            Console.Clear();
            self13_6();
            Console.WriteLine("Нажмите Escape, чтобы перезапустить программу, или любую другую клавишу, чтобы завершить её.");
        }
        while (Console.ReadKey().Key != ConsoleKey.Escape);
    }
    public static void sem1()
    {
        Console.Write("m = ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        int[,] matrix = new int[m, n];
        Random rnd = new Random();
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {
                matrix[i, j] = rnd.Next(-10, 11);
            }
        }
        int resultProd = 1;
        int resultSum = 0;
        for (int i = 0; i < matrix.GetLength(1); ++i)
        {
            resultProd *= matrix[k, i];
            resultSum += matrix[k, i];
        }
        Console.WriteLine(resultSum);
        Console.WriteLine(resultProd);
    }
    public static void self3()
    {
        Console.Write("m = ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];
        Random rnd = new Random();
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {
                matrix[i, j] = rnd.Next(-5, 6);
            }
        }
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {
                Console.Write(matrix[i, j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {

            }
        }
    }
    public static void self4()
    {
        Console.Write("m = ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];
        Random rnd = new Random();
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {
                matrix[i, j] = rnd.Next(-5, 6);
            }
        }
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {
                Console.Write(matrix[i, j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        int[,] matrix2 = new int[m, n];
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {
                matrix2[j, i] = matrix[i, j];
            }
        }
        int[] vector = new int[matrix2.GetLength(1)];
        for (int i = 0; i < matrix2.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix2.GetLength(1); ++j)
            {
                vector[j] += matrix2[i, j];
            }
        }
        for (int i = 0; i < matrix2.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix2.GetLength(1); ++j)
            {
                Console.Write(matrix2[i, j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        foreach (int i in vector)
        {
            Console.WriteLine(i);
        }
    }
    public static void self5()
    {
        Console.Write("m = ");
        int m = int.Parse(Console.ReadLine());
        double[,] matrix = new double[m, m];
        Random rnd = new Random();
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {
                matrix[i, j] = Math.Round((9.33 - -9.25) * rnd.NextDouble() + -9.25, 2);
            }
        }
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {
                Console.Write(matrix[i, j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {

            }
        }
    }
    public static void self6()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Random rnd = new Random();
        for (int i = 0; i < array.Length; ++i)
        {
            array[i] = rnd.Next(-100, 101);
        }
        foreach (int i in array)
        {
            Console.Write(i);
            Console.Write(" ");
        }
        Console.WriteLine();
        int[] Method(int[] array)
        {
            for (int i = 0; i < array.Length - 1; ++i)
            {
                int cnt = 1;
                if ((array[i] + array[i + 1]) % 3 == 0)
                {
                    array[i] = array[i] * array[i + 1];
                    for (int j = i + 1; j < array.Length - 2; ++j)
                    {
                        array[j] = array[j + 1];
                    }
                    array[^cnt] = 0;
                    ++cnt;
                }
            }
            return array;
        }
        array = Method(array);
        foreach (int i in array)
        {
            Console.Write(i);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    public static void self6_1()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        double[,] matrix = new double[n, n];
        Random rnd = new Random();
        int tmp = 1;
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {
                if (j >= tmp)
                {
                    matrix[i, j] = 0;
                }
                else
                {
                    matrix[i, j] = rnd.NextDouble() * (9.33 + 9.25) - 9.25;
                }
            }
            ++tmp;
        }
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {
                Console.Write(matrix[i, j]);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = i + 1; j < matrix.GetLength(1); ++j)
            {
                double tmp1 = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = tmp1;
            }
        }
        Console.WriteLine();
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {
                Console.Write(matrix[i, j]);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
    public static void self7()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("m = ");
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];
        Random rnd = new Random();
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {
                matrix[i, j] = rnd.Next(10, 101);
            }
        }
        int[] array = new int[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            int tmp = int.MaxValue;
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {
                if (matrix[i, j] < tmp)
                {
                    tmp = matrix[i, j];
                }
            }
            array[i] = tmp;
        }
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {
                Console.Write(matrix[i, j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        foreach (int i in array)
        {
            Console.Write(i);
            Console.Write(' ');
        }
        Console.WriteLine();
    }
    public static void self07()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        char[,] matrix = new char[n, n];
        string str = "";
        Random rnd = new Random();
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {
                if (i % 2 == 0)
                {
                    matrix[i, j] = (char)rnd.Next('A', 'Z' + 1);
                }
                else
                {
                    matrix[i, j] = (char)rnd.Next('0', '9' + 1);
                }
                if (i == j)
                {
                    str += matrix[i, j];
                }
            }
        }
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {
                Console.Write(matrix[i, j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.Write(str);
        Console.WriteLine();
    }
    public static void self1_3()
    {
        int[][] array = new int[7][];
        for (int i = 0; i < array.Length; ++i)
        {
            array[i] = new int[array.Length - i];
        }
        for (int i = 0; i < array.Length; ++i)
        {
            for (int j = 0; j < array[i].Length; ++j)
            {
                array[i][j] = i + 1;
            }
        }
        for (int i = 0; i < array.Length; ++i)
        {
            for (int j = 0; j < array[i].Length; ++j)
            {
                Console.Write(array[i][j]);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    public static void self2_3()
    {
        Random rnd = new Random();
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("m = ");
        int m = int.Parse(Console.ReadLine());
        int[][] array = new int[n][];
        for (int i = 0; i < array.Length; ++i)
        {
            array[i] = new int[m];
            for (int j = 0; j < array[i].Length; ++j)
            {
                array[i][j] = rnd.Next(-9, 10);
            }
        }
        int[][] array2 = new int[array.Length][];
        int tmp = 0;
        // Ошибка где то в этой вложенной штуке
        for (int i = 0; i < array.Length; ++i)
        {
            bool flag = true;
            for (int j = 0; j < array[i].Length; ++j)
            {
                for (int h = j + 1; h < array[i].Length; ++h)
                {
                    if (Math.Abs(array[i][j]) == Math.Abs(array[i][h]))
                    {
                        flag = false;
                        break;
                    }
                }
                if (!flag)
                {
                    break;
                }
            }
            if (flag)
            {
                array2[tmp] = new int[m];
                Array.Copy(array[i], array2[tmp], m);

                ++tmp;
            }
        }
        for (int i = 0; i < array.Length; ++i)
        {
            for (int j = 0; j < array[i].Length; ++j)
            {
                Console.Write(array[i][j]);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        // массив оказывается пустым и не печатается
        for (int i = 0; i < array2.Length; ++i)

        {
            for (int j = 0; j < array2[i]?.Length; ++j)
            {
                Console.Write(array2[i][j]);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
    public static void self3_3()
    {
        Console.Write("n нечетно. n = ");
        int n = int.Parse(Console.ReadLine());
        int[][] array = new int[n][];
        // заполняю все элементы до середнины не включильно 
        for (int i = 0; i < n / 2 + 1; ++i)
        {
            array[i] = new int[i];
            for (int j = 0; j < array[i].Length; ++j)
            {
                array[i][j] = j + 1;
            }
        }
        // заполняю вторую половину массива (включая середину) 
        for (int i = 0; i < array.Length; ++i)
        {
            array[i] = new int[n / 2 + 1 - i];
            for (int j = 0; j < array[i].Length; ++j)
            {
                array[i][j] = j + 1;
            }
        }
        for (int i = 0; i < array.Length; ++i)
        {
            for (int j = 0; j < array[i].Length; ++j)
            {
                Console.Write(array[i][j]);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    public static void self4_3()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[][] array = new int[n][];

    }
    public static void self13_1()
    {
        Console.Write("string = ");
        string str1 = Console.ReadLine();
        string[] word = str1.Split(' ');
        Array.Sort(word, (x, y) => x.Length.CompareTo(y.Length));
        foreach (var i in word)
        {
            Console.Write(i);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    public static void self13_2()
    {
        Console.Write("string = ");
        string str = Console.ReadLine();
        string[] words = str.Split(' ');
        foreach (var i in words)
        {
            Console.Write(i);
            Console.Write(" ");
        }
        Console.WriteLine();
        foreach (var word in words)
        {
            if (char.IsLetter(word[0]))
            {
                Console.Write(word);
                Console.Write(' ');
            }
        }
        Console.WriteLine();
    }
    public static void self13_4()
    {
        Console.Write("string = ");
        string str = Console.ReadLine();
        Console.WriteLine(str);
        str = str.Replace("7", "");
        string[] words = str.Split(' ');
        for (var i = 0; i < words.Length; ++i)
        {
            words[i] = "222" + words[i] + "5";
        }
        foreach (var i in words)
        {
            Console.Write(i);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    public static void self13_5()
    {
        Console.Write("string = ");
        string str = Console.ReadLine();
        string[] words = null;
        string digits = "";
        for (int i = 0; i < str.Length; ++i)
        {
            if (char.IsDigit(str[i]) || str[i] == ' ')
            {
                digits += str[i];
            }
            else
            {
                digits += " ";
            }
        }
        string[] digitsArr = digits.Split(' ');
        int[] array = new int[digitsArr.Length];
        for (int i = 0; i < digitsArr.Length; ++i)
        {
            array[i] = int.Parse(digitsArr[i]); // тут программа падает
        }
        Console.WriteLine(array.Max());
    }
    public static void self13_6()
    {
        Console.Write("string = ");
        string str = Console.ReadLine();
        int cnt1 = 0;
        int cnt2 = 0;
        foreach (var i in str)
        {
            if (i == '(')
            {
                cnt1++;
            }
            else if (i == ')')
            {
                cnt2++;
            }
        }
        if (cnt1 == cnt2)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}