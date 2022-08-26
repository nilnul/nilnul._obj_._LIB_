using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj._expr.untyped.be_.ofType_.typed.vow;
using nilnul.obj._func;
using nilnul.obj._func.untyped.be_.ofType_.typed.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using F = nilnul.obj.ExprI4;


namespace nilnul.obj.expr_.typed_
{
	public interface IGeneri<out TRet>
		:obj.IExpr
	{

	}
	/// <summary>
	/// typed lambda.
	/// <see cref="System.Linq.Expressions.Expression<T>"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface GeneriI<  T>
		:
		obj.ExprI4

		,IGeneri<T>
		//,
		//expr_.typed_

	{
		obj.expr.be_.typed_.generi.vow.Ee<T> generi { get; }
	}

	public class Generi<T> :
		obj.expr.be_.typed_.generi.vow.Ee<T>
		,
		GeneriI<T>
	{
		public Generi(F val) : base(val)
		{
		}
		
		public Generi(obj.Expr4 val) : base(val)
		{
		}

		public Generi(Expression sys):this(new obj.Expr4(sys))
		{
		}


		public obj.expr.be_.typed_.generi.vow.Ee<T> generi => this;

		public Ee expr => this.ee.expr;
	}
}
