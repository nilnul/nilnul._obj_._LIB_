using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.dict.be_
{
	[Obsolete("nilnul.rel_.Dict, in that dict is the relation based on set.")]

	public class Bijective<TKey, TVal> : nilnul.obj.dict.BeI<TKey, TVal>
	{
		private IEqualityComparer<TVal> _valEq;

		public IEqualityComparer<TVal> valEq
		{
			get { return _valEq; }
			set { _valEq = value; }
		}

		public Bijective(IEqualityComparer<TVal> valEq)
		{
			_valEq = valEq;
		}
		public bool be(Dictionary<TKey, TVal> obj)
		{
			return nilnul.obj.str.be_.Distinct.Eval(obj.Values, _valEq);
			//throw new NotImplementedException();
		}
	}

	[Obsolete("nilnul.rel_.Dict, in that dict is the relation based on set.")]

	public class Bijective<TKey, TVal, TValEq> : Bijective<TKey, TVal>
		where TValEq : IEqualityComparer<TVal>, new()
	{
		public Bijective() : base(SingletonByDefault<TValEq>.Instance)
		{
		}

		static public Bijective<TKey, TVal, TValEq> Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Bijective<TKey, TVal, TValEq>>.Instance;
			}
		}

	}
}
