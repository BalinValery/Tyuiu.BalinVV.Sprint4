using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BalinVV.Sprint4.Task3.V18.Lib
{
    public class DataService : ISprint4Task3V18
    {
        public int Calculate(int[,] array)
        {
            int res = int.MinValue;
            int lastRowIndex = array.GetLength(0) - 1;

            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[lastRowIndex, j] > res)
                {
                    res = array[lastRowIndex, j];
                }
            }
            return res;
        }
    }
}
