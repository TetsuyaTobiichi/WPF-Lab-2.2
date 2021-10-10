using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPF_Lab_2._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Lab_2._2.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void DelDupTest()
        {
            string forTest = "aaa";
            string message = Logic.DelDup(forTest);
            Assert.AreEqual("aaa", message);
        }

        [TestMethod()]
        public void FindSimilarLettersTest()
        {
            string FirstTestWord = "компьютер";
            string SecondTestWord = "процессор";
            string message = Logic.FindSimilarLetters(logic.DelDup(SecondTestWord), logic.DelDup(FirstTestWord));
            Assert.AreEqual("yes yes yes no yes no ", message);
        }
    }
}