using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.dict
{
	[Obsolete("nilnul.rel_.Dict, in that dict is the relation based on set.")]

	public class Eq<TKey, TVal, TKeyEq> :

		IEqualityComparer<Dict<TKey, TVal, TKeyEq>>
		where TKeyEq : IEqualityComparer<TKey>, new()
	{
		private IEqualityComparer<TVal> _valEq;

		public IEqualityComparer<TVal> valEq
		{
			get { return _valEq; }
			set { _valEq = value; }
		}

		public Eq(IEqualityComparer<TVal> valEq)
		{
			_valEq = valEq;
		}

		public bool Equals(Dict<TKey, TVal, TKeyEq> x, Dict<TKey, TVal, TKeyEq> y)
		{
			return nilnul.obj.set.Eq1<TKey,TKeyEq>.Lazy.Equals(x.Keys, y.Keys)
				&&
				x.Keys.All(
					a => _valEq.Equals(x[a], y[a])
				)
			;
			//throw new NotImplementedException();
		}

		public int GetHashCode(Dict<TKey, TVal, TKeyEq> obj)
		{
			return 0;
			throw new NotImplementedException();
		}
	}
}
