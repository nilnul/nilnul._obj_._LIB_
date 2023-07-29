using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re_
{
	static public class _EqX
	{
		/// <summary>
		/// 
		/// </summary>
		/// vs:
		///		<see cref="_EquivX.SYMBOL"/>
		public const char SYMBOL = '=';
	}
	public class Eq<T>
		: nilnul.obj.Box1<
			IEqualityComparer<T>
		>
		,
		nilnul.obj.ReI<T>
		,
		nilnul.obj.re_.EqI<T>
	{
		public Eq(IEqualityComparer<T> val) : base(val)
		{
		}

		public Eq() : this(
			EqualityComparer<T>.Default
		)
		{

		}

		public bool re(T a, T b)
		{
			return boxed.Equals(a, b);
			//throw new NotImplementedException();
		}
	}
}
