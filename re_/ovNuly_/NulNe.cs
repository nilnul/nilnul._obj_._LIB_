#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re_.ovNuly_
{
	
	

	/// <summary>
	/// this relation is not reflexive, as for it as a rel doesnot have (null,null). It's reflexive for all other nonnull vals.
	/// This rlation is symmetric. For all nonnul vals, it's symmetric; for null, we have no (null,null) thus the symmetricness still holds.
	///
	/// This relation is transitive. For all nonnul vals, it's transitive. For null,we have no (null,null) thus the transitiveness still holds.
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class NulNe<T>
		:
		nilnul.obj.Box1<IEqualityComparer<T>>
		,
		NulNeI<T>

	{
		public NulNe(IEqualityComparer<T> val) : base(val)
		{
		}

		public bool re(T x, T y)
		{
			if (x is null)
			{
				if (y is null)
				{
					return false;
				}
				return false;
			}
			if (y is null)
			{
				return false;
			}
			return boxed.Equals(x, y);
			//throw new NotImplementedException();
		}

	
	}


}
