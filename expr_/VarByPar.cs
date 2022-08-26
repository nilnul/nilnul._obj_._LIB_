using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_
{

	public interface VarI
		:nilnul.obj.ExprI4
	{

		ParameterExpression sys { get; }
	}
	

	public class Var :
		nilnul.obj.Box_pub<ParameterExpression>
		,
		ExprI4
		,
		IVar
		,
		IEquatable<Var>
		,
		VarI
		
		

	{
		public Ee expr => new Ee(this.boxed);

		public ParameterExpression sys => boxed;

		public Var(ParameterExpression val) : base(val)
		{

		}
		

		public bool Equals(Var other)
		{
			return expr_.var.Eq.Singleton.Equals(this, other);
			//throw new NotImplementedException();
		}

		public override int GetHashCode()
		{
			return expr_.var.Eq.Singleton.GetHashCode(this);
		}

		static public  bool operator ==(
			Var x,
			Var y

			) {
			return expr_.var.Eq.Singleton.Equals(x, y);

		}

		public override bool Equals(object obj)
		{
			if (obj is Var var)
			{
				return this == var;
			}
			return base.Equals(obj);
		}
		static public  bool operator !=(
			Var x,
			Var y

			) {
			return !(x== y);

		}

	}
}
