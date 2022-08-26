using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.dict
{
	[Obsolete("nilnul.rel_.Dict, in that dict is the relation based on set.")]

	public class Eq<TKey, TVal> : 
		
		IEqualityComparer<Dictionary<TKey, TVal>>
	{
		private IEqualityComparer<TKey> _keyEq;

		public IEqualityComparer<TKey> keyEq
		{
			get { return _keyEq; }
			set { _keyEq = value;
				_keySetEq=new set.Eq<TKey>(_keyEq);
			}
		}

		private IEqualityComparer<TVal> _valEq;

		public IEqualityComparer<TVal> valEq
		{
			get { return _valEq; }
			set { _valEq = value; }
		}

		private nilnul.obj.set.Eq<TKey> _keySetEq;
			
		public nilnul.obj.set.Eq<TKey> keySetEq
		{
			get { return _keySetEq; }
		}


		public Eq(IEqualityComparer<TKey> keyEq, IEqualityComparer<TVal> valEq)
		{
			_keyEq = keyEq;
			_valEq = valEq;

		}

		public bool Equals(Dictionary<TKey, TVal> x, Dictionary<TKey, TVal> y)
		{
			nilnul.obj.vow_.True.Vow(x.Comparer == _keyEq);
			nilnul.obj.vow_.True.Vow(y.Comparer==_keyEq);

			return _keySetEq.Equals(x.Keys, y.Keys) 
				&& 
				x.Keys.All( 
					a=>_valEq.Equals( x[a],y[a] )
				)
			;


			//throw new NotImplementedException();
		}

		public int GetHashCode(Dictionary<TKey, TVal> obj)
		{
			nilnul.obj.vow_.True.Vow(obj.Comparer == _keyEq);
			return 0;

			//throw new NotImplementedException();
		}
	}
}
