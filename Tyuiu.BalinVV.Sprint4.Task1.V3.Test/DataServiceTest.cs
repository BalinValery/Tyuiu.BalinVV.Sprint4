using Tyuiu.BalinVV.Sprint4.Task1.V3.Lib;
namespace Tyuiu.BalinVV.Sprint4.Task1.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 8, 8, 9, 6, 5, 3, 2, 9, 7, 7, 7 };
            int res = ds.Calculate(numsArray);
            int Wait = 3072;
            Assert.AreEqual(Wait, res);
        }
    }
    
}
