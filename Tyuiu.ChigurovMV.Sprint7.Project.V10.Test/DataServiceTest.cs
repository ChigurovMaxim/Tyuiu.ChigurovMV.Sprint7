using Tyuiu.ChigurovMV.Sprint7.Project.V10.Lib;
namespace Tyuiu.ChigurovMV.Sprint7.Project.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMatrix()
        {
            DataService ds = new DataService();
            string path = $@"C:\DataSprint7\TestFileData.csv";
            string[,] waitArray = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
            var resArray = ds.GetMatrix(path);
            CollectionAssert.AreEqual(waitArray, resArray);
        }
    }
}