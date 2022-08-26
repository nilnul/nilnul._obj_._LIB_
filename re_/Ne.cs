using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re_
{

	public class Ne<T>
		: nilnul.obj.Box1<
			IEqualityComparer<T>
		>
		,
		nilnul.obj.ReI<T>
		
		
	{
		public Ne(IEqualityComparer<T> val) : base(val)
		{
		}

		public Ne() : this(
			EqualityComparer<T>.Default
		)
		{

		}

		public bool re(T a, T b)
		{
			return !boxed.Equals(a, b);
			//throw new NotImplementedException();
		}
	}
}
