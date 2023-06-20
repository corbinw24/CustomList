using CustomList;
using System.ComponentModel;

namespace CustomListTest
{
    [TestClass]
    public class AddMethodTests
    {
        

        [TestMethod]
        public void AddItem_AddOneInt_CountShouldIncreaseToOne()
        {
            List<string> myList = new List<string>();

            // Act
            myList.Add("First");
            myList.Add("Second");

            // Assert
            Assert.AreEqual(2, myList.Count);
            Assert.AreEqual("First", myList[0]);
            Assert.AreEqual("Second", myList[1]);
        }

        [TestMethod]
        public void CapacityIncreasesWhenExceededAndOriginalItemsPersist()
        {
            // Arrange
            List<string> myList = new List<string>(2);

            // Act
            myList.Add("First");
            myList.Add("Second");
            myList.Add("Third");

            // Assert
            Assert.AreEqual(3, myList.Count);
            Assert.AreEqual("First", myList[0]);
            Assert.AreEqual("Second", myList[1]);
        }

    }
}