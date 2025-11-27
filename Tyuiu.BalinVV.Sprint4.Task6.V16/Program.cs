using Tyuiu.BalinVV.Sprint4.Task6.V16.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Балин В.В. | СМАРТб-25-1";
        Console.WriteLine("###########################################################################");
        Console.WriteLine("# Спринт #4                                                               #");
        Console.WriteLine("# Тема: Класс Array                                                       #");
        Console.WriteLine("# Задание #6                                                              #");
        Console.WriteLine("# Вариант #16                                                             #");
        Console.WriteLine("# Выполнил Балин В.В. | СМАРТб-25-1                                       #");
        Console.WriteLine("###########################################################################");
        Console.WriteLine("# УСЛОВИЕ:                                                                #");
        Console.WriteLine("# Дан строковый массив данных  [\"Автомобиль\", \"Велосипед\",            #");
        Console.WriteLine("# \"Самолет\", \"Поезд\", \"Трамвай\", \"Троллейбус\", \"Метро\"],        #");
        Console.WriteLine("# используя класс Array, выведите элементы массива, длина которых равна   #");
        Console.WriteLine("# 8 символам.                                                             #");
        Console.WriteLine("###########################################################################");
        Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
        Console.WriteLine("###########################################################################");

        string[] array = { "Автомобиль", "Велосипед", "Самолет", "Поезд", "Трамвай", "Троллейбус", "Метро" };
        string[] res = ds.Calculate(array);

        Console.WriteLine("###########################################################################");
        Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
        Console.WriteLine("###########################################################################");

        Console.Write("Элементы массива, длинна которых равна 7 символам: ");
        for (int i = 0; i < res.Length; i++)
        {
            Console.Write(res[i] + " ");
        }
        Console.ReadKey();
    }
}