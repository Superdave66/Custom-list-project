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
        public void IncreaseMaxCapacitySizeCheckLastIndex()
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
            actual = testList[5];

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}