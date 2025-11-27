using Tyuiu.BalinVV.Sprint4.Task6.V16.Lib;
namespace Tyuiu.BalinVV.Sprint4.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValidCalculate()
        {
            DataService ds = new DataService();

            string[] array = { "Автомобиль", "Велосипед", "Самолет", "Поезд", "Трамвай", "Троллейбус", "Метро" };
            string[] res = ds.Calculate(array);
            string[] wait = { "Самолет", "Трамвай" };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
