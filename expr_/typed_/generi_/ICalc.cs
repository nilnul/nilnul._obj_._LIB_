using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr.be_.typed_.generi.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using s = System.Linq.Expressions;


namespace nilnul.obj.expr_.typed_.generi_
{

	/// <summary>
	/// </summary>
	public  interface ICalc
	{
	}

	/// <summary>
	/// an expression that, if all vars are substituted by vals, evaluates to an instance of <typeparamref name="T"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface ICalc<out T> : ICalc {

	}



	public class Calc<T> :
		nilnul.obj.expr_.typed_.generi.be_.calc.vow.Ee<T>
		,
		GeneriI<T>
		,
		nilnul.obj.CalcI<T>
	{
		


		public Calc(GeneriI<T> val) : base(val)
		{
		}

		public Ee<T> generi => boxed.generi;

		public Ee expr =>boxed.expr;

		public T calc() {
			return _CalcX._Calc_assumeNoVar<T>(this.ee.expr.ee);
			//return System.Linq.Expressions.Expression.Lambda<Func<T>>(this.ee.expr.ee).Compile()();


		}
	}
}
