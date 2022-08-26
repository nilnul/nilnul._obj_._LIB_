using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._bound.lowerUpper.be_.spanned_
{
	public class ComparerDefault_OnDenseObj<T, TLower, TUpper, TEq>
		:
		lowerUpper.be_.Spanned_OnDenseObj<T, TLower, TUpper>

		where TLower : _bound.LowerI<T>
		where TUpper : _bound.UpperI<T>
		where TEq : IComparer<T>, new()

	{
		public ComparerDefault_OnDenseObj() : base(nilnul.obj_.Singleton<TEq>.Instance)
		{
		}

		static public ComparerDefault_OnDenseObj<T, TLower, TUpper, TEq> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<ComparerDefault_OnDenseObj<T, TLower, TUpper, TEq>>.Instance;
			}
		}

	}
}
