
using global::System;
using global::System.Collections.Generic;
using global::System.Linq;
using global::System.Linq.Expressions;
using global::System.Text;
using global::System.Threading;
using global::System.Runtime.Serialization; 
internal static partial class __NGSHelpers
{
	public static HashSet<T> ToSet<T>(this IEnumerable<T> collection)
	{
		return new HashSet<T>(collection);
	}
}
