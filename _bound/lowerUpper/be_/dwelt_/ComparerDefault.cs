using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._bound.lowerUpper.be_.dwelt_
{
	public class ComparerDefault_OnDenseObj<T, TLower, TUpper, TComparer>
		:
		lowerUpper.be_.Dwelt<T, TLower, TUpper>

		where TLower : _bound.LowerI<T>
		where TUpper : _bound.UpperI<T>
		where TComparer : IComparer<T>, new()

	{
		public ComparerDefault_OnDenseObj() : base(nilnul.obj_.Singleton<TComparer>.Instance)
		{
		}

		static public ComparerDefault_OnDenseObj<T, TLower, TUpper, TComparer> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<ComparerDefault_OnDenseObj<T, TLower, TUpper, TComparer>>.Instance;
			}
		}

	}
}
