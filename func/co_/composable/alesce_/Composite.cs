using nilnul.obj._func;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FuncI1 = nilnul.obj._func.FuncI_dynamic;
using nilnul.obj.var.set.ordered;
using nilnul.obj._func.func;

namespace nilnul.obj.func.duo.composable.op
{
	public class Composite
	{
		static public FuncI1 _Eval__assertComposable(FuncI1 f, FuncI1 f1)
		{

			if (f.vars.Count() == 0)
			{
				if (f1.vars.Count() == 0)
				{

					return f;

				}
				return new Func(f1.vars.toDehead(), f.expr);

			}

			if (f1.vars.Count() == 0)
			{
				return new Func(f.vars.toDehead(), f.expr.substitute(f.vars.First(), f1.expr));
			}

			///rename if vars are conflicted
			/// 

			var newF1 = f1;
			foreach (var item in f1.vars.ToList())
			{
				if (f.vars.Contains(item))
				{
					newF1 = newF1.Rename(item, new _var.Var_dynamicTyped(item.type));
				}

			}


			var orderedNew = new var.set.Ordered(var.set.Ordered.TruncateLast(f.vars).Union(newF1.vars));

			return new Func(
				orderedNew
				,
				f.expr.substitute(f.vars.Last(), newF1.expr)
			);


			throw new UnexpectedReachException();



		}
		/// <summary>
		/// apply with all vars of f1, feed to the head var of f, then abstract all vars of f1.
		/// </summary>
		/// <param name="f">if vars are empty, it's assumed there is a var that's new and different from any other.</param>
		/// <param name="f1"></param>
		/// <returns></returns>
		/// 

		static public _func.Func _Eval__assertComposable(Func f, _func.Func f1)
		{

			if (f.vars.Count() == 0)
			{
				if (f1.vars.Count() == 0)
				{

					return f;

				}
				return new Func(f1.vars.toDehead(), f.expr);

			}

			if (f1.vars.Count() == 0)
			{
				return new Func(f.vars.toDehead(), f.expr.substitute(f.vars.First(), f1.expr));
			}

			///rename if vars are conflicted
			/// 

			var newF1 = f1;
			foreach (var item in f1.vars)
			{
				if (f.vars.Contains(item))
				{
					newF1 = newF1.Rename(item, new _var.Var_dynamicTyped(item.type));
				}

			}


			var orderedNew = new var.set.Ordered(var.set.Ordered.TruncateLast(f.vars).Union(newF1.vars));

			return new Func(
				orderedNew
				,
				f.expr.substitute(f.vars.Last(), f1.expr)
			);


			throw new UnexpectedReachException();



		}
		static public _func.Func _Eval__assertLeftEmpty(_func.Func f, _func.Func f1)
		{

				if (f1.vars.Count() == 0)
				{

					return f;

				}
				return new Func(f1.vars.toDehead(), f.expr);

		


			throw new UnexpectedReachException();



		}
		static public _func.Func _Eval__assertBothConstant(_func.Func f, _func.Func f1)
		{
					return f;
		}



	}
}
