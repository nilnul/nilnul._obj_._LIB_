using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream_.slider.of_
{
	/// <summary>
	/// <see cref="nameof(nilnul.obj.op_.unary.recur.Slider)"/>
	/// </summary>
	static public class _RecurX
	{
		public static IEnumerable<TSource> Seq<TSource>(
			TSource start,
			Func<TSource, TSource> step
		)
		{
			TSource current = start;
			while (true)
			{
				yield return current;
				current = step(current);
			}
		}
	}
}
