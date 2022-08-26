using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.lambda
{
	public class CurryX
	{
		public Func<T1, Func<T2, T3>> Curry<T1, T2, T3>(Func<T1, T2, T3> function)
		{
			return a => b => function(a, b);
		}

		public Func<T1, Func<T2, Func<T3, T4>>> Curry<T1, T2, T3, T4>(Func<T1, T2, T3, T4> function)
		{
			return a => b => c => function(a, b, c);
		}

		public Func<T1, Func<T2, Func<T3, Func<T4, T5>>>> Curry<T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5> function)
		{
			return a => b => c => d => function(a, b, c, d);
		}

	}
}
