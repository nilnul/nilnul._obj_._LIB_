using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.var
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Eq<T> : IEqualityComparer<obj.expr_.Var_sys<T>>
	{
		public bool Equals(Var_sys<T> x, Var_sys<T> y)
		{
			return (x.ee==y.ee);
			//return object.ReferenceEquals(x.ee,y.ee);
			throw new NotImplementedException();
		}

		public int GetHashCode(Var_sys<T> obj)
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
