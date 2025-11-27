using Tyuiu.BalinVV.Sprint4.Task3.V18.Lib;
namespace Tyuiu.BalinVV.Sprint4.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValidCalculate()
        {
            DataService ds = new();
            int[,] test = new int[5, 5] { { 2, 4, 2, 7, 7 }, { 4, 7, 9, 9, 7 }, { 8, 5, 5, 6, 5 }, { 7, 7, 5, 2, 9 }, { 9, 3, 7, 9, 8 } };
            Assert.AreEqual(9, ds.Calculate(test));
        }
    }
}
