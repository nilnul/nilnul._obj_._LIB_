using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.of_
{
	static public class _RepeatX
	{
		static public IEnumerable<T> _Repeat_1nonneg<T>(T member, int count) {

			for (int i = 0; i < count; i++)
			{
				yield return member;
			}
		}
	}
}
