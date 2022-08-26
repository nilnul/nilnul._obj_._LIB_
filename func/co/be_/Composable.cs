using nilnul.obj._func;
using nilnul.obj._func.func;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FuncI1 = nilnul.obj._func.FuncI_dynamic;


namespace nilnul.obj.func.duo.be
{
	public class Composable
	{
		static public bool Eval(_duo.Duo duo) {

			if (duo.func.vars.Count()==0)
			{
				return true;
			}
			else
			{
				if ( obj.type.rel.IsSupTypeOfX.Eval(  duo.func.vars.First().type ,duo.func1.expr.type))
				{
					return true;
				}

			}
			return false;
			throw new NotImplementedException();

		}

		static public void Assert(_duo.Duo duo) {

			nilnul.obj.AssertX.True(Eval(duo));

		}
		public class Assertion
		{

			public void assert(_duo.Duo duo) {
				Assert(duo);
			}

			static public Assertion Instance = new Assertion();




		}

		public class Asserted
		{

			private _duo.Duo _duo;

			public _duo.Duo duo
			{
				get { return _duo; }
				set { _duo = value; }
			}

			public Asserted(_duo.Duo duo)
			{
				Assertion.Instance.assert(duo);

			}

			 public FuncI1 compo(FuncI1 f, FuncI1 f1)
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


		}
	}
}
