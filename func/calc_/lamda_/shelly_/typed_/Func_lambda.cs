using nilnul.obj._expr.untyped.be_.ofType_.typed.vow;
using nilnul.obj._func;
using nilnul.obj._func.untyped.be_.ofType_.typed.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// typed lambda
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// 
	[Obsolete(nameof(obj.func.calc_.lamda_.typed_.GeneriI<T>))]
	public interface FuncI_lambda<T>:IFunc
	{
		obj._func.untyped.be_.ofType_.typed.vow.Ee_lambda<T> untyped { get; }
	}

	[Obsolete(nameof(obj.func.calc_.lamda_.typed_.Generi<T>))]
	public class Func_lambda<T> :
		obj._func.untyped.be_.ofType_.typed.vow.Ee_lambda<T>
		,
		FuncI_lambda<T>
	{
		public Func_lambda(LambdaExpression val) : base(val)
		{
		}

		public Ee_lambda<T> untyped => this;
	}
}
