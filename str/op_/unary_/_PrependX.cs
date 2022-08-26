using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.op_.unary_
{

	/// <summary>
	/// prepend
	/// </summary>
	public static class _PrependX
	{
		static public IEnumerable<T> Prepend<T>(T head, IEnumerable<T> tail) {
			yield return head;
			foreach (var item in tail)
			{
				yield return item;
			}

		}
		static public IEnumerable<T> Prepend<T>(this  IEnumerable<T> tail , T head) {
			return Prepend(head, tail);

		}

	}
}
