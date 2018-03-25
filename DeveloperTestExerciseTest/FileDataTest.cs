using System;
using FileData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeveloperTestExerciseTest
{
    [TestClass]
    public class FileDataTest
    {
        [TestMethod]
        public void checkNumberofArguments_correct()
        {
            string[] input = { "--s", "c:/test.tx" };
            Validator newValidator = new Validator();
            newValidator.Args = input;

            Assert.IsTrue(newValidator.validNumberOfArguments(),"Number of Arguments is correct");
        }

        [TestMethod]
        public void checkNumberofArguments_Incorrect()
        {
            string[] input = { "--s", "c:/test.tx", "--v" };
            Validator newValidator = new Validator();
            newValidator.Args = input;

            Assert.IsFalse(newValidator.validNumberOfArguments(), "Number of Arguments is Incorrect");
        }

        [TestMethod]
        public void checkNumberofArguments_NoArguments()
        {
            string[] input = {};
            Validator newValidator = new Validator();
            newValidator.Args = input;

            Assert.IsFalse(newValidator.validNumberOfArguments(), "No Argument is Passed");
        }

        [TestMethod]
        public void CheckValidFunction_ValidVersion()
        {
            Validator newValidator = new Validator();

            string[] input = { "--v", "c:/test.txt" };
            newValidator.Args = input;
            newValidator.FunctionDeterminer = input[0];
            Assert.IsTrue(newValidator.validFunction(), "Valid Version Function request");
        }

        [TestMethod]
        public void CheckValidFunction_ValidSize()
        {
            string[] input = { "--s", "c:/test.txt" };
            Validator newValidator = new Validator();
            newValidator.Args = input;
            newValidator.FunctionDeterminer = input[0];
            Assert.IsTrue(newValidator.validFunction(), "Valid Size Function request");
        }

        [TestMethod]
        public void CheckValidFunction_InvalidCharacter()
        {
            string[] input = { "-/s", "c:/test.txt" };
            Validator newValidator = new Validator();
            newValidator.Args = input;
            newValidator.FunctionDeterminer = input[0];
            Assert.IsFalse(newValidator.validFunction(), "Invalid Function Request");
        }


    }


}
