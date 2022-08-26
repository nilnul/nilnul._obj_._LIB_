using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq
{
	static public class _AsCosX
	{

		static public IEnumerable<(T, T)> AsCos<T>(IEnumerable<T> seq) {

			if (seq.Any())
			{
				return AsCos<T>(seq.First(),nilnul.obj.seq_.headed._TailX._Tail(seq) );
			}

			return new (T,T)[] { };

		}

		private static IEnumerable<(T, T)> AsCos<T>(T t, IEnumerable<T> enumerable)
		{
			foreach (var item in enumerable)
			{

				yield return (t,item);

				t = item;
			};
		}
	}
}
