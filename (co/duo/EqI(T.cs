using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.duo
{
	public interface EqI<T>
		:IEqualityComparer<Duo<T>>
	{
	}



	public class Eq<T, TEq, TDuo> : IEqualityComparer<TDuo>
		where TEq : IEqualityComparer<T>, new()
		where TDuo : Duo<T>
	{
		public bool Equals(TDuo x, TDuo y)
		{
			return SingletonByDefault<TEq>.Instance.Equals(x.Item1, y.Item1) && SingletonByDefault<TEq>.Instance.Equals(x.Item2,y.Item2);
			//throw new NotImplementedException();
		}

		public int GetHashCode(TDuo obj)
		{
			return SingletonByDefault<TEq>.Instance.GetHashCode(obj.Item1) ^ SingletonByDefault<TEq>.Instance.GetHashCode(obj.Item2)	   ;
			//throw new NotImplementedException();
		}

		static public readonly Eq<T,TEq,TDuo> Singleton = nilnul.obj.SingletonByDefault<Eq<T, TEq, TDuo>>.Instance;

	}
}
