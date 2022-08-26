using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using V = nilnul.obj.expr_.typed_.generi_.Var_sys;

namespace nilnul.obj.expr_.typed_.generi_.var
{
	public class Eq<T> : IEqualityComparer<Var<T>>
	{
		public bool Equals(Var<T> x, Var<T> y)
		{
			return (x.ee==y.ee);
			//return object.ReferenceEquals(x.ee,y.ee);
			throw new NotImplementedException();
		}

		public int GetHashCode(Var<T> obj)
		{
			return obj.ee.GetHashCode();
			//throw new NotImplementedException();
		}

		static public Eq<T> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq<T>>.Instance;
			}
		}

	}
}
