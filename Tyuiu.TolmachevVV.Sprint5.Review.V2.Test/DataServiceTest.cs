using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.TolmachevVV.Sprint5.Review.V2.Lib;

namespace Tyuiu.TolmachevVV.Sprint5.Review.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private static readonly string path = @"C:\DataSprint5\InPutDataFileTask7V2.txt";
        [TestMethod]
        public void FileExistenceTest()
        {
            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);
        }

        [TestMethod]
        public void CalculationTest()
        {
            DataService service = new DataService();
            Assert.AreEqual("### Привет, это тестовая строка ###.", File.ReadAllText(service.LoadDataAndSave(path)));
        }
    }
}
