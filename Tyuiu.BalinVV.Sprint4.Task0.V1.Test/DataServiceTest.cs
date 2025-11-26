using Tyuiu.BalinVV.Sprint4.Task0.V1.Lib;
namespace Tyuiu.BalinVV.Sprint4.Task0.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();
            int[] Array = new int[] { 6, 4, 3, 2, 1, 0, 9, 8, 7, 5 };
            int wait = 20;
            int res = ds.GetSumEvenArrEl(Array);
            Assert.AreEqual(wait, res);
        }
    }
}
