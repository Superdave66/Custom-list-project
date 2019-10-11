using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListTests;
namespace CustomListTests
{
    [TestClass]
    public class CustomListTests
    {

        [TestMethod]
        public void Add_AddToEmptyList_ItemGoesToIndexZero()

        {
            // arrange


            CustomList<int> testList = new CustomList<int>();
            int expected = 12;
            int actual;

            //act
            testList.Add(12);
            actual = testList[0];




            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]


        public void GetCount()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;


            // act
            testList.Add(4);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddMultipleAndGetCertainIndex()

        {
            // arrange


            CustomList<int> testList = new CustomList<int>();
            int expected = 12;
            int actual;

            //act
            testList.Add(12);
            testList.Add(14);
            testList.Add(16);
            actual = testList[0];




            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IncreaseMaxCapacitySize()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 5;
            int actual;


            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IncreaseMaxCapacitySizeCheckIndex()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 3;
            int actual;


            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            actual = testList[2];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Removeonefromlistmutipleadded()

        {
            // arrange


            CustomList<int> testList = new CustomList<int>();
            int expected = 2;
            int actual;

            //act
            testList.Add(1); 
            testList.Add(2);
            testList.Add(3);
            testList.Remove(1);
            actual = testList[0];




            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemovesometingNotTherefromlistmutipleadded()

        {
            // arrange


            CustomList<int> testList = new CustomList<int>();
            int expected = 2;
            int actual;

            //act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Remove(4);
            actual = testList[1];




            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveoeMultipleFromlistAddedOverMaxCapacityCheckCount()

        {
            // arrange


            CustomList<int> testList = new CustomList<int>();
            int expected = 2;
            int actual;

            //act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Remove(3);
            testList.Remove(2);
            testList.Remove(1);
            actual = testList.Count;




            //assert
            Assert.AreEqual(expected, actual);
        }
        public void RemoveoeMultipleFromlistAddedOverMaxCapacityCheckCapacity()

        {
            // arrange


            CustomList<int> testList = new CustomList<int>();
            int expected = 8;
            int actual;

            //act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Remove(3);
            testList.Remove(2);
            testList.Remove(1);
            actual = testList.Capacity;




            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemovesometingAddSomethingelsefromlistmutipleadded()

        {
            // arrange


            CustomList<int> testList = new CustomList<int>();
            int expected = 4;
            int actual;

            //act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Remove(2);
            testList.Add(4);
            actual = testList[2];




            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Removesometingcheckcapacity()

        {
            // arrange


            CustomList<int> testList = new CustomList<int>();
            int expected = 4;
            int actual;

            //act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Remove(2);
            actual = testList.Capacity;




            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}