using System;
using System.Collections.Generic;
using System.Linq;

namespace TestHelper
{
	public static class EnumHelper
	{
		public static IEnumerable<T> ToEnumerable<T>()
		{
			return from object e in Enum.GetValues(typeof(T)) select (T)e;
		}
	}
}