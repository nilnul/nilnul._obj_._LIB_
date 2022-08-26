using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.dict.re_.eq_
{
	public class SameKeys<TKey, TVal, TKeyEq>
		: nilnul.obj.ReI<Dict<TKey, TVal, TKeyEq>>

		where TKeyEq : IEqualityComparer<TKey>, new()
	{
		public bool re(Dict<TKey, TVal, TKeyEq> a, Dict<TKey, TVal, TKeyEq> b)
		{
			return nilnul.obj.set.Eq1<TKey, TKeyEq>.Lazy.Equals(a.Keys,b.Keys);
			//throw new NotImplementedException();
		}


		static public SameKeys<TKey, TVal, TKeyEq> Singleton
		{
			get
			{
				return nilnul._obj.Singleton<SameKeys<TKey, TVal, TKeyEq>>.Instance;
			}
		}

	}
}
