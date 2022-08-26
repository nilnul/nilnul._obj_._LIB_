using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._bound.lowerUpper.be_
{
	public class Dwelt<T, TLower, TUpper>
		:
		nilnul.obj.Box<IComparer<T>>
		,
		lowerUpper.BeI<T, TLower, TUpper>
		where TLower : _bound.LowerI<T>
		where TUpper : _bound.UpperI<T>

	{

		public Dwelt(IComparer<T> val) : base(val)
		{
		}

		public bool be(LowerUpperI<T, TLower, TUpper> obj)
		{
			return _SingleX.Be<T, TLower,TUpper>(obj, boxed)
				 ||
				 new Spanned_OnDenseObj<T, TLower, TUpper>(boxed).be(obj)
				;
		}
	}


}
