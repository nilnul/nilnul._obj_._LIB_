using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re_
{

	public interface EqI<T>
			:
		nilnul.obj.re_.IEq1<T>
		,
		nilnul.obj.ReI<T>
	{

	}
	public abstract class EqA<T>
		:
		IEq<T>
		,
		EqI<T>
		,
		IEqualityComparer<T>
	{
		public bool Equals(T x, T y)
		{
			return re(x, y);
		}
		public virtual int GetHashCode(T obj) { return 0; }
		public abstract bool re(T a, T b);

		public override string ToString()
		{
			return "==";
		}
	}
}
