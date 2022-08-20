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
        public void TestMethod1(string Mathematics, string English_Language, string Finance, string Economics, string Physics, string expected)
        {
            int MathematicsScore = int.Parse(Mathematics);
            int English_LanguageScore =int.Parse(English_Language);
            int FinanceScore = int.Parse(Finance);
            int EconomicsScore = int.Parse(Economics);
            int PhysicsScore = int.Parse(Physics);
            var Student_CGPA = new Student_Result();
            int expectedResult = int.Parse(expected);
            var TotalCgpa = Student_CGPA.TotalCgpa(MathematicsScore, English_LanguageScore,FinanceScore, EconomicsScore, PhysicsScore);
            Assert.AreEqual(expectedResult, TotalCgpa);


        }
    }
}
