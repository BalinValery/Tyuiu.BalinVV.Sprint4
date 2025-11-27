using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BalinVV.Sprint4.Task6.V16.Lib
{
    public class DataService : ISprint4Task6V16
    {
        public string[] Calculate(string[] array)
        {
            string[] res = Array.FindAll(array, item => item.Length == 7);
            return res;
        }
    }
}
