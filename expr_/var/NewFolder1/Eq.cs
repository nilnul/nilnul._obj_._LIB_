using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._expr.untyped_.var
{
	[Obsolete()]
	public class Eq : IEqualityComparer<obj._expr.untyped_.Var>
	{
		public bool Equals(Var x, Var y)
		{
			return (x.boxed==y.boxed);
			//return object.ReferenceEquals(x.ee,y.ee);
			
		}

		public int GetHashCode(Var obj)
		{
			return obj.boxed.GetHashCode();
			//throw new NotImplementedException();
		}

		static public Eq Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq>.Instance;
			}
		}

	}
}
