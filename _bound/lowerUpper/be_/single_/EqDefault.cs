using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._bound.lowerUpper.be_.single_
{
	public class EqDefault<T, TLower, TUpper, TEq>
		:
		lowerUpper.be_.Single<T, TLower, TUpper>

		where TLower : _bound.LowerI<T>
		where TUpper : _bound.UpperI<T>
		where TEq : IEqualityComparer<T>, new()

	{
		public EqDefault() : base(nilnul.obj_.Singleton<TEq>.Instance)
		{
		}

		static public EqDefault<T, TLower, TUpper, TEq> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<EqDefault<T, TLower, TUpper, TEq>>.Instance;
			}
		}

	}
}
