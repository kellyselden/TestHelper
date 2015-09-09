using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestHelper.Tests
{
	[TestClass]
	public class EnumHelperTests
	{
		enum Test { Test1 }

		[TestMethod]
		public void TestMethod1()
		{
			var actual = EnumHelper.ToEnumerable<Test>().ToArray();

			Assert.AreEqual(1, actual.Length);
			Assert.AreEqual(Test.Test1, actual.ElementAt(0));
		}
	}
}