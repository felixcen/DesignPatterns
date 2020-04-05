using DesignPatterns.Builder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DesignPatternTests
{
    [TestClass]
    public class HtmlBuilderTest
    {
        [TestMethod]
        public void TestTwoBuildersSameContentSuccess()
        {
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello");
            builder.AddChild("li", "world");

            var builder1 = new HtmlBuilder("ul");
            builder1.AddChild("li", "hello");
            builder1.AddChild("li", "world");

            Console.WriteLine(builder.ToString());

            Assert.AreEqual(builder1.ToString(), builder.ToString());

        }

        [TestMethod]
        public void TestFluentSuccess()
        {
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello");
            builder.AddChild("li", "world");

            Assert.IsTrue(builder.ToString().Length > 0);

            builder.Clear(); 
            Assert.IsTrue(builder.ToString().Equals("<ul>\n</ul>\n") );

            builder.AddChild("li", "hello")
                    .AddChild("li", "world");
            Console.WriteLine(builder);

            Assert.IsTrue(!builder.ToString().Equals("<ul>\n</ul>\n"));
        }
    }


    
}
