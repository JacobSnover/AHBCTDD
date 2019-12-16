using AHBCTDD;
using NUnit.Framework;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //Test attribute allows NUnit framework, to run method as a test
        [Test]
        //test names can be as long as you want, try to make them overly descriptive
        public void AssignNamePropertyValueMustBeEqual()
        {
            Testing testObject = new Testing() { Name = "AHBC" };

            //use Assert statements, to find a true result
            //Assert.AreEqual is looking for both values to be equal
            Assert.AreEqual("AHBC", testObject.Name);
        }

        [Test]
        public void AssignNamePropertyValueMustBeNotEqual()
        {
            Testing testObject = new Testing() { Name = "AHBC" };

            //add test that checks for correct type
            //use typeof keyword to get the type back as a value
            //by passing in the class that we are checking, we will
            //get back the type as a value
            Assert.AreEqual(typeof(Testing), testObject.GetType());

            //Assert.AreNotEqual will return true if the values are different
            Assert.AreNotEqual("ahbc", testObject.Name);
        }

        //create test for a method that doesn't exist yet
        //test methods are always public so the testing framework can access them
        //testing methods are void, because we never want to return a value from a test
        [Test]
        public void AddStringValueToNameProperty()
        {
            //make object we can test off of
            Testing testObject = new Testing() { Name = "AHBC" };

            //we call to our newly created method
            //after letting TDD drive us to this result
            testObject.Name = Testing.AddString(testObject);

            //Assert that are values are Equal
            //modified my test until it failed
            //then refactor the code until test passes
            Assert.AreEqual("AHBC1234", testObject.Name);
        }
    }
}