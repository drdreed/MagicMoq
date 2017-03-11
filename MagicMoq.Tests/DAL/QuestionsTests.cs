using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MagicMoq.DAL;
using Moq;
using System.Collections.Generic;

namespace MagicMoq.Tests.DAL
{
    [TestClass]
    public class QuestionsTests
    {
        private Mock<Answers> mock_answers { get; set; }
        private Questions questions { get; set; }

        [TestInitialize]
        public void Setup() {
            // Runs BEFORE every test
            mock_answers = new Mock<Answers>();
            questions = new Questions(mock_answers.Object);
        }

        [TestCleanup]
        public void Cleanup()
        {
            // Runs AFTER every test
            mock_answers = null;
            questions = null;
        }

        [TestMethod]
        public void EnsureICanCreateQuestionsInstance()
        {
            Questions questions = new Questions();
            Assert.IsNotNull(questions);
        }

        [TestMethod]
        public void EnsureICanCreateAnswersInstance()
        {
            Answers answers = new Answers();
            Assert.IsNotNull(answers);
        }

        [TestMethod]
        public void EnsureQuestionsReturnsAnswersInstance()
        {
            // Hint: Implement a Constructor (for Questions class)
            Questions questions = new Questions();

            Assert.IsNotNull(questions.Wand);
        }

        [TestMethod]
        public void EnsureQuestionsReturnsInjectedAnswersInstance()
        {

            // Hint 1: Create an instance of your Answers class
            Answers answers = new Answers();

            // Hint 2: Implement another Constructor (for Questions class)
            Questions questions = new Questions(answers);

            Assert.IsNotNull(questions.Wand);
        }

        [TestMethod]
        public void EnsureSayHelloReturnsHelloWorld()
        {

            // Add code that mocks the "HelloWorld" method response
            mock_answers.Setup(a => a.HelloWorld()).Returns("Hello World");

            

            // Act
            string expected_result = "Hello World";
            string actual_result = questions.SayHelloWorld();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureOneMinusOneReturnsZero()
        {
            // Add code that mocks the "Zero" method response
            mock_answers.Setup(a => a.Zero()).Returns(0);

            

            // Act
            int expected_result = 0;
            int actual_result = questions.OneMinusOne();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
            mock_answers.Verify(a => a.Zero());
        }

        [TestMethod]
        public void EnsureOnePlusOneReturnsTwo()
        {
            // Add code that mocks the "Two" method response
            mock_answers.Setup(a => a.Two()).Returns(2);

            

            // Act
            int expected_result = 2;
            int actual_result = questions.OnePlusOne();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
            mock_answers.Verify(a => a.Two());
        }

        [TestMethod]
        public void EnsureOnePlusTwoReturnsThree()
        {
            // Add code that mocks the "Three" method response
            
            mock_answers.Setup(a => a.Three()).Returns(3);

            // Act
            int expected_result = 3;
            int actual_result = questions.OnePlusTwo();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
            mock_answers.Verify(a => a.Three());
        }

        [TestMethod]
        public void EnsureThisReturnsTrue()
        {
            // Add code that mocks the "True" method response
            mock_answers.Setup(a => a.True()).Returns(true);

            

            // Act
            bool expected_result = true;
            bool actual_result = questions.ReturnTrue();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureThisReturnsFalse()
        {
            // Add code that mocks the "False" method response
            mock_answers.Setup(a => a.False()).Returns(false);

            

            // Act
            bool expected_result = false;
            bool actual_result = questions.ReturnFalse();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureSayNothingReturnsEmptyString()
        {
            // Add code that mocks the "EmptyString" method response
            mock_answers.Setup(a => a.EmptyString()).Returns("");

            

            // Act
            string expected_result = "";
            string actual_result = questions.SayNothing();
            
            // Assert
            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureTwoPlusTwoReturnsFour()
        {
            // Add code that mocks the "Four" method response
            mock_answers.Setup(a => a.Four()).Returns(4);

            

            // Act
            int expected_result = 4;
            int actual_result = questions.TwoPlusTwo();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
            mock_answers.Verify(a => a.Four());
        }

        [TestMethod]
        public void EnsureFourMinusTwoPlusOneReturnsThree()
        {
            // Add code that mocks the "Three" method response
            mock_answers.Setup(a => a.Three()).Returns(3);

            

            // Act
            int expected_result = 3;
            int actual_result = questions.FourMinusTwoPlusOne();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
            mock_answers.Verify(a => a.Three());
        }

        [TestMethod]
        public void EnsureFourMinusTwoReturnsTwo()
        {
            // Add code that mocks the "Two" method response
            mock_answers.Setup(a => a.Two()).Returns(2);

            

            // Act
            int expected_result = 2;
            int actual_result = questions.FourMinusTwo();

            // Assert
            Assert.AreEqual(expected_result, actual_result);
            mock_answers.Verify(a => a.Two());
        }

        [TestMethod]
        public void EnsureCountToFiveReturnsListOfFiveInts()
        {
            // Add code that mocks the "ListOfFiveInts" method response
            mock_answers.Setup(a => a.ListOfNInts(It.IsAny<int>())).Returns(new List<int> { 1, 2, 3, 4, 5});

            

            // Act
            List<int> expected_result = new List<int> { 1, 2, 3, 4, 5 };
            List<int> actual_result = questions.CountToFive();

            // Assert
            CollectionAssert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureFirstThreeEvenIntsReturnsListOfThreeEvenInts()
        {
            // Add code that mocks the "ListOfFiveInts" method response
            mock_answers.Setup(a => a.ListOfNInts(It.IsAny<int>())).Returns(new List<int> { 1, 2, 3, 4, 5, 6 });

            

            // Act
            List<int> expected_result = new List<int> { 2, 4, 6 };
            List<int> actual_result = questions.FirstThreeEvenInts();

            // Assert
            CollectionAssert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureFirstThreeOddIntsReturnsListOfThreeOddInts()
        {
            // Add code that mocks the "ListOfFiveInts" method response
            mock_answers.Setup(a => a.ListOfNInts(It.IsAny<int>())).Returns(new List<int> { 1, 3, 5 });

            

            // Act
            List<int> expected_result = new List<int> { 1, 3, 5 };
            List<int> actual_result = questions.FirstThreeOddInts();

            // Assert
            CollectionAssert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureZeroPlusZeroReturnsZero()
        {
            mock_answers.Setup(a => a.Zero()).Returns(0);
            
            int expected_result = 0;
            int actual_result = questions.ZeroPlusZero();

            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureFourPlusZeroReturnsFour()
        {
            mock_answers.Setup(a => a.Four()).Returns(4);
            
            int expected_result = 4;
            int actual_result = questions.FourPlusZero();

            Assert.AreEqual(expected_result, actual_result);
        }

        [TestMethod]
        public void EnsureTwoMinusZeroReturnsTwo()
        {
            mock_answers.Setup(a => a.Two()).Returns(2);
            
            int expected_result = 2;
            int actual_result = questions.TwoMinusZero();

            Assert.AreEqual(expected_result, actual_result);
        }

    }
}
