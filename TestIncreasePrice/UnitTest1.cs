using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OODExam_JonathanODonnell_S00180206;

namespace TestIncreasePrice
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIncrease()
        {
            //Arrange
            Phone phone1 = new Phone();
            decimal expectedPhonePrice = 550m;
            //Act
            phone1.Price = 500m;
            //phone1.

            //Assert
            Assert.AreEqual(expectedPhonePrice, phone1.Price);
        }
    }
}
