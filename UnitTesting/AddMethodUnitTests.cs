using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListUnitTest
{
    [TestClass]
    public class AddMethodUnitTests
    {
        [TestMethod]
        public void Add_Item_CountIncreasedByOne()
        {
            //Arrange
            CustomList<int> listOfNumbers = new CustomList<int>();
            int number = 20;
            int expected = 1;
            int actual;


            //Act 

            listOfNumbers.Add(number);
            actual = listOfNumbers.Count;



            //Assert

            Assert.AreEqual(expected, actual);

        }

       [TestMethod]
       public void Add_Item_CountIncreasedByTwo()
        {
            //Arrange
            CustomList<int> ListOfNumbers = new CustomList<int>();
            int number1 = 1;
            int number2 = 2;
            int expected = 2;
            int actual;


            //Act
            ListOfNumbers.Add(number1);
            ListOfNumbers.Add(number2);
            actual = ListOfNumbers.Count;



            //Assert
            Assert.AreEqual(expected, actual);
        }
        //Check indexes after values are added
        //Check value inside certain index
        //Check capacity increase after values are added to index
        //

        [TestMethod]
        public void Add_Item_CapacityIs4()
        {
            //Arrange
            CustomList<int> ListOfNumbers = new CustomList<int>();
            int number1 = 1;
            int number2 = 2;
            int number3 = 3;
            int expected = 4;
            int actual;

            //Act

            ListOfNumbers.Add(number1);
            ListOfNumbers.Add(number2);
            ListOfNumbers.Add(number3);
            actual = ListOfNumbers.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);

        }



        //smal

        [TestMethod]
        public void Add_Item_CheckItemOfIndex0()
        {
            //Arrange
            CustomList<int> ListOfNumbers = new CustomList<int>();
            int number1 = 1;
            int number2 = 2;
            int number3 = 3;
            int expected = 1;
            int actual;

            //Act

            ListOfNumbers.Add(number1);
            ListOfNumbers.Add(number2);
            ListOfNumbers.Add(number3);
            actual = ListOfNumbers[0];

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_Item_ValueOfIndex2()
        {
            //Arrange
            CustomList<int> ListOfNumbers = new CustomList<int>();
            int number1 = 1;
            int number2 = 2;
            int number3 = 3;
            int expected = 3;
            int actual;

            //Act

            ListOfNumbers.Add(number1);
            ListOfNumbers.Add(number2);
            ListOfNumbers.Add(number3);
            actual = ListOfNumbers[2];

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_Item_CapacityDoublingCheck()
        {
            //Arrange
            CustomList<int> ListOfNumbers = new CustomList<int>();
            int number1 = 1;
            int number2 = 2;
            int number3 = 3;
            int number4 = 4;
            int number5 = 5;
            int expected = 8;
            int actual;

            //Act

            ListOfNumbers.Add(number1);
            ListOfNumbers.Add(number2);
            ListOfNumbers.Add(number3);
            ListOfNumbers.Add(number4);          
            ListOfNumbers.Add(number5);
            actual = ListOfNumbers.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);

        }

    }
}
