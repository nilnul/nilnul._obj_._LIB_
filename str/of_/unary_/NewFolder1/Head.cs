using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.convert_
{
	[Obsolete(nameof(str.op_.unary_._HeadX))]
	public static class _HeadX
	{
		static public IEnumerable<T> Head<T>(T head, IEnumerable<T> tail) {
			yield return head;
			foreach (var item in tail)
			{
				yield return item;
			}

		}
	}
}
