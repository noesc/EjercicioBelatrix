using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BelatrixRefactored;
using Moq;
using Data;

namespace JobLoggerTest
{
    [TestClass]
    public class JobLoggerTests
    {
        private Mock<IHelper> helper;

        [TestInitialize]
        public void Init()
        {
            helper = new Mock<IHelper>();
            helper.Setup(x => x.GetConfigurationRestrictionTypeMessage()).Returns(1);
            helper.Setup(x => x.GetPathFile()).Returns(@"C:\EjercicioBelatrix\JobLogger\");
            helper.Setup(x => x.GetConnectionString()).Returns(@"");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void LogMessageNullTest()
        {
            //arrange
            JobLogger log = new JobLogger(1,null,helper.Object);
            
            //act
            log.LogMessage();

            //assert
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void LogMessageEmptyTest()
        {
            //arrange
            JobLogger log = new JobLogger(1, String.Empty, helper.Object);

            //act
            log.LogMessage();

            //assert
        }

        [TestMethod]
        public void LogFile()
        {
            // arrange
            string path = helper.Object.GetPathFile();
            JobLogger log = new JobLogger(1, "Hi World", helper.Object);

            //act
            log.LogMessage();
            Console.WriteLine("Exit");

            string[] message = System.IO.File.ReadAllLines(path + "LogFile" + DateTime.Now.ToString("MM-dd-yy") + ".txt");

            //assert
            Assert.AreNotEqual(String.Empty, message[0]);
        }
    }
}
