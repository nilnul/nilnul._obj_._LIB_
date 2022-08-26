using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.op_.unary_
{

	/// <summary>
	/// append
	/// </summary>
	public static class _AppendX
	{
		static public IEnumerable<T> Append<T>(IEnumerable<T> tail, T tip ) {
			foreach (var item in tail)
			{
				yield return item;
			}
			yield return tip;

		}
	}
}
