using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.var
{
	public class Eq :
		IEqualityComparer<obj.expr_.VarI>
		,
		IEqualityComparer<obj.expr_.Var>
		,
		IEqualityComparer<ParameterExpression>

	{
		public bool Equals(obj.expr_.Var x, obj.expr_.Var y)
		{
			return (x.boxed==y.boxed);
			//return object.ReferenceEquals(x.ee,y.ee);
			
		}

		public int GetHashCode(obj.expr_.Var obj)
		{
			return obj.boxed.GetHashCode();
			//throw new NotImplementedException();
		}

		public bool Equals(ParameterExpression x, ParameterExpression y)
		{
			return x == y;
		}

		public int GetHashCode(ParameterExpression obj)
		{
			return obj.GetHashCode();
		//	throw new NotImplementedException();
		}

		public bool Equals(VarI x, VarI y)
		{
			return x.sys == y.sys;
			//throw new NotImplementedException();
		}

		public int GetHashCode(VarI obj)
		{
			return obj.sys.GetHashCode();
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
