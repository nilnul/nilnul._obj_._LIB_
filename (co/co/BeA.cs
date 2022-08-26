using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co
{
	#region not implementable

#if true

	public abstract class BeA<T, TCo>
		:
		nilnul.obj.BeI1<TCo>
		where TCo : nilnul.obj.CoI2<T>
	{
		public bool be(TCo obj)
		{
			return be(obj.component, obj.component1);
		}
		public abstract bool be(T a, T b);
	}
#endif

	#endregion

	public abstract class BeOnReA<T, TCo>
		:
		nilnul.obj.ReI<T>
		where TCo : nilnul.obj.CoI2<T>
	{
		public bool be(TCo obj)
		{
			return re(obj.component, obj.component1);
		}
		public abstract bool re(T a, T b);
	}

	public abstract class BeA<T>
	:
		nilnul.obj.BeI1<nilnul.obj.Co<T>>
		,
		_be_.OfSpreadI<T>
	{
		public abstract bool be(nilnul.obj.Co<T> obj);
		public bool be(T a, T b)
		{
			return be(new obj.Co<T>(a, b));
		}
	}




}
