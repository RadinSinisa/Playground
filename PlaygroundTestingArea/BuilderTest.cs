using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinqBuilder;

namespace PlaygroundTestingArea
{
    [TestClass]
    public class BuilderTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void BuildIntegerSequenceTest()
        {
            //Aranage
            Builder listBuilder = new Builder();

            //Act
            var result = listBuilder.BuilderIntegerSequence();

            //Analyze
            foreach (var item in result)
            {
                TestContext.WriteLine(item.ToString());
            }

            //Asert
            Assert.IsNotNull(result);

        }
    }
}
