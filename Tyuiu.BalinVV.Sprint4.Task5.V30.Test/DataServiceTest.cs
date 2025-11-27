using Tyuiu.BalinVV.Sprint4.Task5.V30.Lib;
namespace Tyuiu.BalinVV.Sprint4.Task5.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[,] { {-1,-1,-1,-1,-1 },
                                         {-1,-1,-1,-1,-1 },
                                         {-1,-1,-1,-1,-1 },
                                         {-1,-1,-1,-1,-1 },
                                         {-1,-1,-1,-1,4 }
                                            };

            int res = ds.Calculate(matrix);
            int wait = 4;

            Assert.AreEqual(wait, res);
        }
    }
}
