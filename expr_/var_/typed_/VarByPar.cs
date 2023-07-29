using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_
{

	/// <summary>
	/// the type info is provided here. expose those info to any interface that needs those info;
	/// <see cref="expr_.typed_.generi_.Var{T}"/>
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	/// <typeparam name="T"></typeparam>

	[Obsolete(nameof(expr_.typed_.generi_.Var<T>))]
	public class Var_sys<T> : _var.untyped.be.vow.Ee<T>
		,
		nilnul.obj.expr_.IVar
		,
		IEquatable<Var_sys<T>>
		,
		ExprI_sys<T>
		,
		expr_.var_.ITyped
		

	{
		public nilnul.obj._expr.untyped.be_.ofType_.typed.vow.Ee<T> untyped => new nilnul.obj._expr.untyped.be_.ofType_.typed.vow.Ee<T>(this.ee);

		public Var_sys(ParameterExpression val) : base(val)
		{

		}
		public Var_sys():this(
			Expression.Parameter(typeof(T) )
		)
		{

		}
		public Var_sys(string s):this(
			Expression.Parameter(typeof(T), s)
		)
		{

		}

		public bool Equals(Var_sys<T> other)
		{
			return expr_.var.Eq<T>.Singleton.Equals(this, other);
			//throw new NotImplementedException();
		}

		public override int GetHashCode()
		{
			return expr_.var.Eq<T>.Singleton.GetHashCode(this);
		}

		static public  bool operator ==(
			Var_sys<T> x,
			Var_sys<T> y

			) {
			return expr_.var.Eq<T>.Singleton.Equals(x, y);

		}

		public override bool Equals(object obj)
		{
			if (obj is Var_sys<T> var)
			{
				return this == var;
			}
			return base.Equals(obj);
		}
		static public  bool operator !=(
			Var_sys<T> x,
			Var_sys<T> y

			) {
			return !(x== y);

		}

	}
}
