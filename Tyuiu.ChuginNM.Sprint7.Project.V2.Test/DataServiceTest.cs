using Tyuiu.ChuginNM.Sprint7.Project.V2.Lib;

namespace Tyuiu.ChuginNM.Sprint7.Project.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            Assert.IsNotNull(DataService.GetMatrix(@"C:\Users\CDOOR\source\repos\Tyuiu.ChuginNM.Sprint7\dataBailOutTest.csv"));
        }
    }
}
