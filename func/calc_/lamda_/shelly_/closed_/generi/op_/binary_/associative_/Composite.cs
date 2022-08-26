using nilnul.obj._func;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FuncI1 = nilnul.obj._func.FuncI_dynamic;
using nilnul.obj.var.set.ordered;
using nilnul.obj._func.func;
using System.Linq.Expressions;
using nilnul.obj.func.op_.unary_;
using nilnul.obj.expr;
using static nilnul.obj.expr._VarsX1;
using nilnul.obj.func;
using nilnul.obj.func.calc_.lamda;

namespace nilnul.obj.func.calc_.lamda_.closed_.generi.op_.binary_.associative_
{
	static public class _CompositeLeft2rightX
	{


		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="_filter1_assumeNonni"></param>
		/// <returns></returns>
		/// <remarks>
		///
		/// </remarks>
		/// Whereas ref arguments may be modified, out arguments must be modified by the called method, and those modifications are observable in the calling context.
		/// -------https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/in-parameter-modifier
		static public void MakeParsNotInOther(ref LambdaExpression filter, ref LambdaExpression _filter1_assumeNonni)
		{

			///rename if pars are in other's vars 
			/// 

			var varsOfLast = _filter1_assumeNonni._Reps_assumeFlat();

			foreach (var item in filter.Parameters)
			{
				if (varsOfLast.Contains(item))
				{
					filter = filter._LambdaReparred_lambdaAssumeFunc(item, out ParameterExpression newPar);
				}
			}


			var varsOfFirstBody = filter.Body._Vars_assumeExpr();

			foreach (var item in _filter1_assumeNonni.Parameters)
			{
				if (varsOfFirstBody.Contains(item))
				{
					_filter1_assumeNonni = _filter1_assumeNonni._LambdaReparred_lambdaAssumeFunc(item, out ParameterExpression newPar);
				}
			}


		}

		/// <summary>
		/// we first literalize the first function. and then feed the result to the second function. And then parameterize all the pars of the first function, and the tail pars of the second function.
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="filter1"></param>
		/// <returns></returns>
		static public LambdaExpression _assumeNis(LambdaExpression filter, LambdaExpression filter1)
		{
			return filter1;
		}
		/// <summary>
		/// we first literalize the first function. and then feed the result to the second function. And then parameterize all the pars of the first function, and the tail pars of the second function.
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="_filter1_assumeNi"></param>
		/// <returns></returns>
		static public LambdaExpression _lastAssumeNi_assumeParsNotInOtherVars(
			LambdaExpression filter
			,
			LambdaExpression _filter1_assumeNi
		) {


			return LambdaExpression.Lambda(
				_filter1_assumeNi.Body
				,
				filter.Parameters
			);

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="first"></param>
		/// <param name="_last_assumeNonni">
		///	if the first par is type mismatch with the <paramref name="first"/>'s expr, an exception will be thrown when compile.
		/// </param>
		/// <returns></returns>
		/// <remarks>
		/// note function bodies may still have some common free vars
		/// </remarks>
		static public LambdaExpression _lastAssumeNonni_assumeParsNotInOtherVars(
			LambdaExpression first
			,
			LambdaExpression _last_assumeNonni
		) {

			return LambdaExpression.Lambda(
				nilnul.obj.expr.var._SubstituteX.Substitute(
					_last_assumeNonni.Body
					,
					_last_assumeNonni.Parameters.First()
					,
					first.Body

				)
				,
				first.Parameters.Concat(
					_last_assumeNonni.Parameters.Skip(1)
				)
			);

		}


		static public LambdaExpression _lastAssumeNonni(
			LambdaExpression filter
			,
			LambdaExpression _filter1_assumeNonni
		) {



			MakeParsNotInOther(ref filter, ref _filter1_assumeNonni);

			return _lastAssumeNonni_assumeParsNotInOtherVars(filter,_filter1_assumeNonni);



		}
		/// <summary>
		/// apply with all vars of f1, feed to the head var of f, then abstract all vars of f1.
		/// </summary>
		/// <param name="f">if vars are empty, it's assumed there is a var that's new and different from any other.</param>
		/// <param name="f1"></param>
		/// <returns></returns>
		/// 

		static public LambdaExpression _assumeParsNotInOtherVars(LambdaExpression f, LambdaExpression f1)
		{
			if (f1.Parameters.Any() )
			{
				return _lastAssumeNonni_assumeParsNotInOtherVars(f, f1);
			}

			return _lastAssumeNi_assumeParsNotInOtherVars(f, f1);



		}




	
		static public LambdaExpression Lambda(LambdaExpression filter, LambdaExpression _filter1_assumeNonni)
		{

			MakeParsNotInOther(ref filter, ref _filter1_assumeNonni);

			
			return _assumeParsNotInOtherVars(filter, _filter1_assumeNonni);


		}



	}
	public class CompoLeft2right<T>
		:
		op_.binary_.AssociativeI<T>	// proof that this is associative by thinking of a nulary function as a unary function with a par not shown in body.

	{
		

		public Generi<T> op(Generi<T> par, Generi<T> par1)
		{
			return new Generi<T>( _CompositeLeft2rightX.Lambda(par.ee.ee, par1.ee.ee) );

		}

		static public CompoLeft2right<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<CompoLeft2right<T>>.Instance;
			}
		}

	}

}
