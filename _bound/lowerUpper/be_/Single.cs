using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._bound.lowerUpper.be_
{
	static public class _SingleX
	{
		static public bool Be<T, TLower, TUpper>(LowerUpperI<T, TLower, TUpper> obj, IEqualityComparer<T> eq)
		where TLower : _bound.LowerI<T>
		where TUpper : _bound.UpperI<T>
		{
			return obj.lower.openFalseCloseTrue && obj.upper.openFalseCloseTrue && eq.Equals( obj.lower.mark,obj.upper.mark);

		}
		static public bool Be<T, TLower, TUpper>(LowerUpperI<T, TLower, TUpper> obj, IComparer<T> eq)
		where TLower : _bound.LowerI<T>
		where TUpper : _bound.UpperI<T>
		{
			return Be(obj, new nilnul.obj.eq_.OvComparer<T>(eq) );

		}


	}
	public class Single<T, TLower, TUpper>
		:
		nilnul.obj.Box<IEqualityComparer<T>>
		,
		lowerUpper.BeI<T, TLower, TUpper>
		where TLower : _bound.LowerI<T>
		where TUpper : _bound.UpperI<T>

	{
		public Single(IEqualityComparer<T> val) : base(val)
		{
		}

		public bool be(LowerUpperI<T, TLower, TUpper> obj)
		{
			return _SingleX.Be(obj, boxed); ;
		}
	}


}
