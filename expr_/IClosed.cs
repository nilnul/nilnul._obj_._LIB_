using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.expr_
{

	/// <summary>
	/// subexpr, including the expr itself, any var, any interim input/output, is of the same type
	/// </summary>
	/// <remarks>
	/// closed form in that the var, the expr are of the same type parameter.
	/// vs: <see cref="nameof(System.Linq.Expressions.Expression)"/>
	///		Expression is of various type parameter, hence closed if we abstract the type parameter as an object type.
	///
	/// </remarks>
	public  interface IClosed:capsule_.ISubexprSameType
	{
	}

	/// <summary>
	/// an expression that, if all vars are substituted by vals, evaluates to an instance of <typeparamref name="T"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	[Obsolete(nameof(expr_.typed_.generi_.closed))]
	public interface IClosed< T> : IClosed , capsule_.ISubexprSameType<T>{

	}

	[Obsolete(nameof(expr_.typed_.generi_.closed))]
	public class Closed1<T> : nilnul.obj.expr.be_.closed.vow.Ee<T>

	{
		public Closed1(ExprI_sys<T> val) : base(val)
		{
		}
	}
}
