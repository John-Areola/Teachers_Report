using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Student_Cgp;

namespace CGPA_Report_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("5","5","5","5","5","5")]
        [DataRow("4", "4", "4", "4", "4", "4")]
        [DataRow("3", "3", "3", "3", "3", "3")]
        public void TestMethod1()
        {
            int Mathematics = int.Parse(Mathematics);
            int English_Language =int.Parse(English_Language);
            int FinanceScore = int.Parse(Finance);
            int EconomicsScore = int.Parse(Economics);
            int PhysicsScore= int. Pa
            var Student_CGPA = new Student_Result();
            var TotalCgpa = Student_CGPA.TotalCgpa(5, 5, 5, 5, 5);
            Assert.AreEqual(5, TotalCgpa);


        }
    }
}
