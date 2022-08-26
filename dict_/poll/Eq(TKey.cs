using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.dict_.poll
{
	public class Eq<TKey> : dict.Eq<TKey, bool>,
		IEqualityComparer<Poll<TKey>>
	{
		public Eq(IEqualityComparer<TKey> keyEq) : base(keyEq, EqualityComparer<bool>.Default)
		{
		}

		public bool Equals(Poll<TKey> x, Poll<TKey> y)
		{
			return base.Equals(x, y);
			throw new NotImplementedException();
		}

		public int GetHashCode(Poll<TKey> obj)
		{
			return base.GetHashCode(obj);
			throw new NotImplementedException();
		}
	}
}
