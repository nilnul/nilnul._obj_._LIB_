using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._expr.untyped_
{
	[Obsolete(nameof(obj.expr_.IVar))]
	public interface IVar {

	}

	[Obsolete(nameof(obj.expr_.Var))]
	public class Var :
		nilnul.obj.Box_pub<ParameterExpression>,
		UntypedI
		,
		IVar
		,
		IEquatable<Var>
		
		

	{
		public Ee lambda => new Ee(this.boxed);

		public Var(ParameterExpression val) : base(val)
		{

		}
		

		public bool Equals(Var other)
		{
			return _expr.untyped_.var.Eq.Singleton.Equals(this, other);
			//throw new NotImplementedException();
		}

		public override int GetHashCode()
		{
			return _expr.untyped_.var.Eq.Singleton.GetHashCode(this);
		}

		static public  bool operator ==(
			Var x,
			Var y

			) {
			return _expr.untyped_.var.Eq.Singleton.Equals(x, y);

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
