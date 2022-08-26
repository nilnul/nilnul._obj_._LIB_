using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var
{
	/// <summary>
	/// this is the default one: Reference Eq. So this is necessary.
	/// </summary>
	[Obsolete(nameof(expr_.var.Eq))]

	public class Eq1<T,TVar> : IEqualityComparer<TVar>
		where TVar:VarI6<T>
	{
		static public readonly Eq1<T,TVar> Instance = new Eq1<T,TVar>();

		public bool Equals(TVar x, TVar y)
		{
			return Eq1.Instance.Equals(x, y);
			return object.ReferenceEquals(x, y);

			//throw new NotImplementedException();
		}

		public int GetHashCode(TVar obj)
		{
			return Eq1.Instance.GetHashCode(obj);
			//throw new NotImplementedException();
		}
	}


}
