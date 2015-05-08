using DeepEqual.Syntax;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestHelper
{
	public static class AssertHelper
	{
		public static void AreDeeplyEqual(object expected, object actual)
		{
			Assert.IsTrue(expected.IsDeepEqual(actual));
		}
	}
}