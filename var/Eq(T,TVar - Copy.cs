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
	public class Eq<T,TVar> : IEqualityComparer<TVar>
		where TVar:VarI5<T>
	{
		static public readonly Eq<T,TVar> Instance = new Eq<T,TVar>();

		public bool Equals(TVar x, TVar y)
		{
			return object.ReferenceEquals(x, y);

			//throw new NotImplementedException();
		}

		public int GetHashCode(TVar obj)
		{
			return obj.GetHashCode();
			//throw new NotImplementedException();
		}
	}


}
