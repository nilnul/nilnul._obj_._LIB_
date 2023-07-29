using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr.be_.typed_.generi.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.typed_.generi_
{

	

	public class Var<T>
		:
		_var.sys.be.vow.Ee<T>
		,
		nilnul.obj.expr_.typed_.generi_.VarI<T>
		,
		IEquatable<Var<T>>
		,
		typed_.generi_.ClosedI<T>
		//,
		//typed_.GeneriI<T>
		

	{
		

		public Ee<T> generi =>new Ee<T>(
			new Expr4(
				this
			)
		);

		public Ee expr => new Ee(this);

		public ParameterExpression sys => this.ee;

		public generi.be_.closed.vow.Ee<T> closed => new typed_.generi.be_.closed.vow.Ee<T>(this);

		public Var(ParameterExpression val) : base(val)
		{

		}
		public Var():this(
			Expression.Parameter(typeof(T) )
		)
		{

		}
		public Var(string s):this(
			Expression.Parameter(typeof(T), s)
		)
		{

		}

		public bool Equals(Var<T> other)
		{
			return var.Eq<T>.Singleton.Equals(this, other);
			//throw new NotImplementedException();
		}

		public override int GetHashCode()
		{
			return var.Eq<T>.Singleton.GetHashCode(this);
		}

		static public  bool operator ==(
			Var<T> x,
			Var<T> y

			) {
			return var.Eq<T>.Singleton.Equals(x, y);

		}

		public override bool Equals(object obj)
		{
			if (obj is Var<T> var)
			{
				return this == var;
			}
			return base.Equals(obj);
		}
		static public  bool operator !=(
			Var<T> x,
			Var<T> y

			) {
			return !(x== y);

		}

	}
}
