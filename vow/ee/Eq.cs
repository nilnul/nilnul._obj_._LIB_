using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._avow_;

namespace nilnul.obj.vow.en
{
	public class Eq<T>
		: IEqualityComparer<En<T>>
	{
		private IEqualityComparer<T> _eq;

		public IEqualityComparer<T> eq
		{
			get { return _eq; }
			set { _eq = value; }
		}


		public Eq(IEqualityComparer<T> eq)
		{
			_eq = eq;
		}
		public bool Equals(En<T> x, En<T> y)
		{
			return _eq.Equals(x.en, y.en);
			//throw new NotImplementedException();
		}

		public int GetHashCode(En<T> obj)
		{
			return _eq.GetHashCode(obj.en);

			//throw new NotImplementedException();
		}



	}

	public class Eq<T, TEq> : Eq<T>
		where TEq : IEqualityComparer<T>, new()
	{
		public Eq() : base(nilnul.obj.SingletonByDefault<TEq>.Instance)
		{
		}


		static public Eq<T,TEq> Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Eq<T,TEq>>.Instance;
			}
		}

	}
}
