using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.vec_.tro
{
	public class Eq<T>
		:
		nilnul.obj.Box1<
			IEqualityComparer<T>
		>
		,
		IEqualityComparer<(T, T, T)>
	{
		public Eq(IEqualityComparer<T> val) : base(val)
		{
		}

		public bool Equals((T, T, T) x, (T, T, T) y)
		{
			return
				boxed.Equals(
				x.Item1, y.Item1
				)
				&&
				boxed.Equals(
				x.Item2, y.Item2
				)
				&&
				boxed.Equals(
				x.Item3, y.Item3
				)
;

		}

		public int GetHashCode((T, T, T) x)
		{
			return
				boxed.GetHashCode(
				x.Item1
				)
				&
				boxed.GetHashCode(
				x.Item2
				)
				&
				boxed.GetHashCode(
				x.Item3
				)
			
;


		}
	}
}
