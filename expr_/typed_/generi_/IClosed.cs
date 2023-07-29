using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr.be_.typed_.generi.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.expr_.typed_.generi_
{

	/// <summary>
	/// closed form in that the var, the expr are of the same type parameter.
	/// vs: <see cref="nameof(System.Linq.Expressions.Expression)"/>
	///		Expression is of various type parameter, hence closed if we abstract the type parameter as an object type.
	/// </summary>
	public interface IClosed
	{
	}

	/// <summary>
	/// an expression that, if all vars are substituted by vals, evaluates to an instance of <typeparamref name="T"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IClosed<out T> : IClosed
	{

	}

	public interface ClosedI<T>
		: IClosed<T>
		,
		GeneriI<T>
	{
		nilnul.obj.expr_.typed_.generi.be_.closed.vow.Ee<T> closed { get; }
	}

	public class Closed<T> :
		nilnul.obj.expr_.typed_.generi.be_.closed.vow.Ee<T>
		,
		ClosedI<T>
		,
		GeneriI<T>
	{
		public Closed(GeneriI<T> val) : base(val)
		{
		}
		public Closed(Generi<T> val) : base(val)
		{
		}

		public Closed(obj.ExprI4 expr) : this(new Generi<T>(expr))
		{


		}
		public Closed(obj.Expr4 expr) : this(new Generi<T>(expr))
		{


		}

		public Closed(System.Linq.Expressions.Expression expr) : this(new Generi<T>(expr))
		{

		}


		public Ee<T> generi => this.ee.generi;

		public Ee expr => this.ee.expr;

		public generi.be_.closed.vow.Ee<T> closed => this;
	}
}
