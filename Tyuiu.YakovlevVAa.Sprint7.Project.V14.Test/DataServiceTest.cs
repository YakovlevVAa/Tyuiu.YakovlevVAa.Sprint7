using Tyuiu.YakovlevVAa.Sprint7.Project.V14.Lib;
namespace Tyuiu.YakovlevVAa.Sprint7.Project.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        private string testFilePath = "testData.csv";
        [TestMethod]
        public void Setup()
        {
            var lines = new[]
        {
            "Column1,Column2,Column3",
            "Data1,Data2,Data3",
            "Data4,Data5,Data6"
        };
            File.WriteAllLines(testFilePath, lines);
        }
        public void Cleanup()
        {
            // Удаляем файл после теста, если он существует
            if (File.Exists(testFilePath))
            {
                File.Delete(testFilePath);
            }
        }
        public void Test_LoadCsvData_ReturnsCorrectData()
        {
            // Act
            var result = ds.LoadCsvData(testFilePath);

            // Assert
            var expectedData = new List<string[]>
        {
            new string[] { "Column1", "Column2", "Column3" },
            new string[] { "Data1", "Data2", "Data3" },
            new string[] { "Data4", "Data5", "Data6" }
        };

            Assert.AreEqual(expectedData.Count, result.Count);
            for (int i = 0; i < expectedData.Count; i++)
            {
                Assert.AreEqual(expectedData[i], result[i]);
            }
        }


    }
}