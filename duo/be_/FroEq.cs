using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.duo.be_
{
	public class FroEq<T> : nilnul.obj.duo.BeI1<T>
	{
		private IEqualityComparer<T> _eq;

		public IEqualityComparer<T> eq
		{
			get { return _eq; }
			set { _eq = value; }
		}

		public FroEq(IEqualityComparer<T> eq)
		{
			_eq = eq;
		}
		public bool be(Tuple<T, T> obj)
		{
			return _eq.Equals(obj.Item1, obj.Item2);

			//throw new NotImplementedException();
		}
	}

	public class FroEq<T, TEq> : FroEq<T>
		where TEq : IEqualityComparer<T>, new()
	{
		public FroEq() : base(SingletonByDefault<TEq>.Instance)
		{
		}
	}
}
