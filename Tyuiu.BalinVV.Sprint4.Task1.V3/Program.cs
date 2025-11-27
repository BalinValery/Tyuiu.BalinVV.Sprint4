using Tyuiu.BalinVV.Sprint4.Task1.V3.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Балин В.В. | СМАРТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #3                                                              *");
        Console.WriteLine("* Выполнил: Балин В.В. | СМАРТб-25-1                                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный         *");
        Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 9 подсчитать сумму нечетных *");
        Console.WriteLine("* элементов массива.С клавиатуры:  4, 8, 8, 9, 6, 5, 3, 2, 9, 7, 7, 7     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Исходный массив:");
        int len;
        Console.WriteLine("Введите количество элементов массива: ");
        len = Convert.ToInt32(Console.ReadLine());

        int[] numsArray = new int[len];

        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine("Введите значение " + i + " элемент массива: ");
            numsArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine("Массив: ");

        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine(numsArray[i] + "\t");

        }
        Console.WriteLine();
        Console.WriteLine();



        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = ds.Calculate(numsArray);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}