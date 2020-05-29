using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        private static string FilePath = @"Data.json";
        [TestMethod]
        public static void TestMethod1()
        {
            var Days = JsonConvert.DeserializeObject<List<W1.WorkingDay>>(File.ReadAllText(FilePath));
            int res = W1.Program.HoursOnProject(Days);
            Assert.AreEqual(res, 49);
        }
    }
}
