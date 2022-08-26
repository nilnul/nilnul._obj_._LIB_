using nilnul.obj._expr.untyped.be_.ofType_.typed.vow;
using nilnul.obj._func;
using nilnul.obj._func.untyped.be_.ofType_.typed.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda_.typed_
{
	public interface IGeneri<out TRet>
		:obj.IFunc
	{

	}
	/// <summary>
	/// typed lambda.
	/// <see cref="System.Linq.Expressions.Expression<T>"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface GeneriI< T>:IFunc
		,IGeneri<T>

	{
		obj.func.calc_.lamda.be_.typed_.generi.vow.Ee_lambda<T> untyped { get; }
	}

	public class Generi<T> :
		obj.func.calc_.lamda.be_.typed_.generi.vow.Ee_lambda<T>
		,
		GeneriI<T>
	{
		public Generi(LambdaExpression val) : base(val)
		{
		}

		public obj.func.calc_.lamda.be_.typed_.generi.vow.Ee_lambda<T> untyped => this;

		static public implicit operator Generi<T>(Expression<T> sys) {
			return new Generi<T>(sys);
		}
	}
}
