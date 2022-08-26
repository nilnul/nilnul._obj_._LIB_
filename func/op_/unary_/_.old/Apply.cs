using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func.op
{
	public partial class Apply
	{
		static public FuncI1<ExprParam,ExprRet> Eval<Param, ExprParam,ExprRet>(

			FuncI1<Param,FuncI1<ExprParam,ExprRet>> func
			, 
			expr.ExprI<Param> arg
		)
		{
			 func.ret.substitute(func.param, arg);
			 return func.ret;
	
		}

		static public FuncI<ExprParam,ExprRet> Eval<Param, ExprParam,ExprRet>(

			FuncI<Param,FuncI<ExprParam,ExprRet>> func
			, 
			expr.ExprI<Param> arg
		)
		{

			return func.rule.substitute(func.param, arg);
	
		}

		static public FuncI<ExprParam,ExprRet> Eval<Param, ExprParam,ExprRet>(

			FuncI<Param,FuncI<ExprParam,ExprRet>> func
			, 
			Param arg
		)
		{

			return Eval(func, new nilnul.obj.expr.Call<Param>( arg));
	
		}

		static public Expr<TInExpr> Eval<Param, TInExpr>(

			FuncI<Param, FuncI<Void,Expr<TInExpr>>> func
			, 
			expr.ExprI<Param> arg
		)
		{
			var x= Eval<Param,Void,Expr<TInExpr>>(func,arg);

			return x.rule;

		}

		static public Expr<TInExpr> Eval<Param, TInExpr>(

			FuncI<Param, FuncI<Void,Expr<TInExpr>>> func
			, 
			Param arg
		)
		{
			return  Eval<Param,TInExpr>(func, new nilnul.obj.expr.Call<Param>( arg));

			

		}

		static public Expr<TInExpr> Eval<Param, TInExpr>(

			FuncI<Param, Expr<TInExpr>> func
			, 
			expr.ExprI<Param> arg
		)
		{
			

			return Eval(func as FuncI<Param,FuncI<Void,Expr<TInExpr>>> ,arg);

		}
		static public Expr<TInExpr> Eval<Param, TInExpr>(

			FuncI<Param, Expr<TInExpr>> func
			, 
			Param arg
		)
		{
			

			return Eval(func  ,new expr.Call<Param>(arg));

		}
		static public Expr<TInExpr> Eval<TInExpr, Arg>(

			Expr<TInExpr> func
			, 
			expr.ExprI<Arg> arg
		)
		{
			return func;

		}


		public class Call<Param,RuleParam,RuleRet  >

			//where TFunc:ApplicableI<TArg>
			//where TFunc:SubstituteInPlaceI<TArg>
			//where TFunc:ParamI<TArg>


		{
			private nilnul.obj.expr.ExprI< Param> _arg;

			public nilnul.obj.expr.ExprI<Param> arg
			{
				get { return _arg; }
				set { _arg = value; }
			}

			private FuncI<Param,FuncI<RuleParam,RuleRet>> _func;

			public FuncI<Param, FuncI< RuleParam,RuleRet>> func
			{
				get { return _func; }
				set { _func = value; }
			}

			public Call( FuncI<Param,FuncI< RuleParam,RuleRet>> func, nilnul.obj.expr.ExprI<Param> arg )
			{
				_arg = arg;
				_func = func;
			}





			public FuncI<RuleParam,RuleRet>  eval()
			{
							
				return Eval(func,arg);

				throw new NotImplementedException();
			}
		}
	}
}
