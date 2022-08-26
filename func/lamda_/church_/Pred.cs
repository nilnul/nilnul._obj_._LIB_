using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.lamda_.church_
{
	static  class _PredX
	{
		static public Func<T, Func<T1, T>> True<T,T1>(
		)
		{
			return (T x) => (T1 y) => x;
		}

		static public Func<T, Func<T1, T1>> False<T,T1>(
		)
		{
			return (T x) => (T1 y) => y;
		}

	}
}
