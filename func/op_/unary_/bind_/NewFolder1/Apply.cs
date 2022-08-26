using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func.mono.op
{
	public class Apply
	{



		public class Call
		{
			private _func.FuncI_dynamic _func;

			public _func.FuncI_dynamic  func
			{
				get { return _func; }
				set { _func = value; }
			}

			private _expr.ExprI_dynamic _arg;

			public _expr.ExprI_dynamic arg
			{
				get { return _arg; }
				set { _arg = value; }
			}


			public Call(
				_func.FuncI_dynamic func, object arg
			)
				:this(func, new _expr.Form(arg))
			{



			}


			public Call( _func.FuncI_dynamic func, _expr.ExprI_dynamic arg)
			{
				Assert(func, arg);

				this._func = func;
				_arg = arg;

			}

			 public _func.FuncI_dynamic eval()
			{

				if (func.vars.Count() == 0)
				{
					return func;
				}
				else
				{
					return new _func.Func(
						func.vars.toDehead()
						,
						func.expr.substitute(func.vars.First(), arg)
					);
				}

			}

			public override string ToString()
			{
				return $"({_func})({_arg})";
            }





		}

		static public void Assert(_func.FuncI_dynamic func, _expr.ExprI_dynamic arg) {

			nilnul.obj.AssertX.True(
				IsApplicable(
					func,arg
				)	
			);

		}

		static public bool IsApplicable( _func.FuncI_dynamic func, _expr.ExprI_dynamic arg) {

			if (func.vars.Count()==0)
			{
				return true;
			}

			return nilnul.obj.type.rel.IsSupTypeOfX.Eval(func.vars.First().type, arg.type);
			
		}
	}

	static public partial class ApplyStatic
	{
		static public _func.FuncI_dynamic Eval(this _func.FuncI_dynamic func, _expr.ExprI_dynamic arg)
			
		{

			if (func.vars.Count()==0)
			{
				return func;
			}
			else
			{
				return new _func.Func(
					func.vars.toDehead()
					,
					func.expr.substitute(func.vars.First(),arg)	
				);
			}

		}
		static public _func.FuncI_dynamic Eval(this _func.FuncI_dynamic func, _form.Literal arg)
			
		{

			if (func.vars.Count()==0)
			{
				return func;
			}
			else
			{
				return new _func.Func(
					func.vars.toDehead()
					,
					func.expr.substitute(func.vars.First(), new _expr.Form( arg))	
				);
			}

		}

		static public _func.FuncI_dynamic Eval(this _func.FuncI_dynamic func, _form.FormI_dynamic arg)
			
		{

			if (func.vars.Count()==0)
			{
				return func;
			}
			else
			{
				return new _func.Func(
					func.vars.toDehead()
					,
					func.expr.substitute(
						func.vars.First()
							,
						 
						new _expr.Form( arg)
					)	
				);
			}
		}








	}
}
