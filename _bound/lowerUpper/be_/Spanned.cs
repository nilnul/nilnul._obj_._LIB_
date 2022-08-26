using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._bound.lowerUpper.be_
{


	public class Spanned_OnDenseObj<T, TLower, TUpper>
		:
		nilnul.obj.Box<IComparer<T>>
		,
		lowerUpper.BeI<T, TLower, TUpper>
		where TLower : _bound.LowerI<T>
		where TUpper : _bound.UpperI<T>

	{
		public Spanned_OnDenseObj(IComparer<T> val) : base(val)
		{
		}
		[Obsolete(" for integers, (1,2), where 1<2, but the bound is empty ",false)]
		public bool be(LowerUpperI<T, TLower, TUpper> obj)
		{
			return boxed.Compare ( obj.lower.mark,obj.upper.mark) <0;
		}
	}


}
