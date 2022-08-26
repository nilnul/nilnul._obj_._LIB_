using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq.enumerator
{
	static public class _MoveNextX
	{
		static public void MoveNext<T>(this IEnumerator<T> enumerator, int times) {
			while (times>0)
			{
				enumerator.MoveNext();
				times--;
			}
		}
	}
}
