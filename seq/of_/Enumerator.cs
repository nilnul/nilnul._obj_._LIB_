using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq.of_
{
	public class Enumerator
	{
		static public IEnumerable<T> Seq<T>(IEnumerator<T> enumerator) {
			while (enumerator.MoveNext())
			{
				yield return enumerator.Current;
			}
		}
	}
}
