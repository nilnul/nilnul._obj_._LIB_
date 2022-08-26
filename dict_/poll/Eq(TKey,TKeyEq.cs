using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.dict_.poll
{
	public class Eq<TKey,TKeyEq> : Eq<TKey>,
		IEqualityComparer<Poll<TKey,TKeyEq>>
		where TKeyEq:IEqualityComparer<TKey>,new()
	{
		public Eq() : base(nilnul._obj.Singleton<TKeyEq>.Instance)
		{
		}

		public bool Equals(Poll<TKey,TKeyEq> x, Poll<TKey,TKeyEq> y)
		{
			return base.Equals(x, y);
			throw new NotImplementedException();
		}

		public int GetHashCode(Poll<TKey,TKeyEq> obj)
		{
			return base.GetHashCode(obj);
			throw new NotImplementedException();
		}

		static public Eq<TKey, TKeyEq> Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Eq<TKey, TKeyEq>>.Instance;
			}
		}

	}
}
