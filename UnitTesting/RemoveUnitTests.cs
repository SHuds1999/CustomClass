using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;
namespace CustomListUnitTest
{
    [TestClass]
    public class RemoveUnitTests
    {
        
        [TestMethod]
        public void Remove_Unit_RemoveItemCountDecreasedByOne()
        {
            //Arrage
            CustomList<int> ListOfNumbers = new CustomList<int>();
           int number1 = 1;
           int number2 = 2;
           int number3 = 3;
           int expected = 2;
            int actual;



            //Act
            ListOfNumbers.Add(number1);
            ListOfNumbers.Add(number2);
            ListOfNumbers.Add(number3);
            ListOfNumbers.Remove(number3);
            actual = ListOfNumbers.Count;

           //Assert
            Assert.AreEqual(expected, actual);

        }


            [TestMethod]
            public void Remove_Unit_RemoveItemCountDecreasedByTwo()
            {
                //Arrage
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
                ListOfNumbers.Remove(number3);
                ListOfNumbers.Remove(number2);
                actual = ListOfNumbers.Count;

                //Assert
               Assert.AreEqual(expected, actual);

            }

            [TestMethod]
            public void Remove_Unit_CapacityIs4()
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
                ListOfNumbers.Remove(number5);
                ListOfNumbers.Remove(number4);
               ListOfNumbers.Remove(number3);
                actual = ListOfNumbers.Capacity;

                //Assert
                Assert.AreEqual(expected, actual);

            }


        [TestMethod]
        public void Remove_Unit_ValueOfIndex2()
        {
            //Arrange
            CustomList<int> ListOfNumbers = new CustomList<int>();
            int number1 = 20;
            int number2 = 30;
            int number3 = 50;
            int number4 = 70;
            int expected = 70;
            int actual;

            //Act

            ListOfNumbers.Add(number1);
            ListOfNumbers.Add(number2);
            ListOfNumbers.Add(number3);
            ListOfNumbers.Add(number4);
            ListOfNumbers.Remove(number3);
            actual = ListOfNumbers[2];

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
       public void Remove_Unit_ValueOfIndex2_Test2()
        {
           //Arrange
            CustomList<int> ListOfNumbers = new CustomList<int>();
           int number1 = 20;           
            int number3 = 50;
            int number4 = 70;
           int expected = 50;
            int actual;

            //Act

            ListOfNumbers.Add(number1);
            ListOfNumbers.Add(number3);
            ListOfNumbers.Add(number4);
           ListOfNumbers.Add(number3);
            ListOfNumbers.Remove(number3);
            actual = ListOfNumbers[2];

            //Assert
            Assert.AreEqual(expected, actual);

        }


    }
}