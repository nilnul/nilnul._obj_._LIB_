using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func
{
	public partial interface ParamsI
	{

		ParamsI compo(ParamsI x);
	}

	public class ParamNone:ParamsI
	{
		static public ParamNone Singleton = SingletonByDefault<ParamNone>.Instance;



		public ParamsI compo(ParamsI x)
		{
			return x;
			throw new NotImplementedException();
		}
		public ParamNone compo(ParamNone x)
		{
			return x;
			throw new NotImplementedException();
		}
		public Params<T,TOthers> compo<T,TOthers>(Params<T,TOthers> x)
		{
			return x;
			throw new NotImplementedException();
		}
	}



	public class Params<T,TOthers>
		:ParamsI
		where TOthers:ParamsI
	{
		public nilnul.obj.VarI3<T> var;
		public TOthers remaining;

		public Params(
			obj.VarI3<T> var,
			TOthers others
		)
		{
			this.var = var;
			this.remaining = others;

		}

		public Params<T,TOthers> compo(ParamNone x)
		{
			return this;

			throw new NotImplementedException();
		}

		public Params<T> compo<T1,TOthers1>(Params<T1,TOthers1> x)
		{
			//if TOthers is ParamNone
			//else	// must be Params<T2,TOthers2>
			//
			///so, if we don't know the complete list of type of variables in TOthers1.vars, we cannot proceed.
			return new Params<T>(var, remaining.compo(x));

			throw new NotImplementedException();
		}

		public Params<T> compo(ParamsI x)
		{
			return new Params<T>(var, remaining.compo(x));

			throw new NotImplementedException();
		}

		ParamsI ParamsI.compo(ParamsI x)
		{
			return compo(x);
			throw new NotImplementedException();
		}
	}

	public class Params<T>:Params<T,ParamsI>,ParamsI
	{
		public Params(
			obj.VarI3<T> var,
			ParamsI others
		):base(var,others)
		{


		}
		public ParamsI compo(ParamsI x)
		{
			return new Params<T>(this.var, this.remaining.compo(x));
			throw new NotImplementedException();
		}
		
	}

	public class ParamsCompo
	{
		static public ParamNone Eval(ParamNone x, ParamNone y) {
			return ParamNone.Singleton;
		}

		static public ParamsI Eval(ParamNone x, ParamsI y) {

			return y;
		
		}

		static public ParamsI Eval(ParamsI x, ParamNone y) {
			return Eval(y, x);
		}

		static public ParamsI Eval(ParamsI x, ParamsI y) {
			return x.compo(y);
		}

		static public Params<T> Eval<T >(Params<T> x, ParamsI y) { 
			return new Params<T>(x.var,Eval(x.remaining,y));
		}

		static public Params<T, TOther> Eval<T,TOther,T1, TOther1>(
			Params<T,TOther> x
			,Params<T1,TOther1> y
			
			) {



				throw new NotImplementedException();
		
		}

		public class Call<T,T1>
			:ParamsI
			where T:ParamsI
			where T1:ParamsI

		{
			private T _paramS;

			public T paramS
			{
				get { return _paramS; }
				set { _paramS = value; }
			}

			private T1 _params1;

			public T1 params1
			{
				get { return _params1; }
				set { _params1 = value; }
			}

			public Call(
				T	x,
				T1 y
			)
			{
			}

			public ParamsI compo(ParamsI x)
			{
				return new Call<T, Call<T1, ParamsI>>(
					paramS,  
					new Call<T1,ParamsI>( params1,(x))
				);
				throw new NotImplementedException();
			}
		}
		
	}

	public class ParamUnary<T>:Params<T,ParamNone>,ParamsI
	{

	}

	public class ParamsExpr<TParams,TInExpr>
		where TParams:ParamsI
	{
		public TParams paramS;
		public nilnul.obj.expr.ExprI<TInExpr> expr;

		public ParamsExpr(TParams paramS, nilnul.obj.expr.ExprI<TInExpr> expr)
		{
			this.paramS = paramS;
			this.expr = expr;
		}

		public ParamsExpr<TParams, TInNewExpr> exprReplace<TInNewExpr>(nilnul.obj.expr.ExprI<TInNewExpr> expr) {
			return new ParamsExpr<TParams, TInNewExpr>(paramS, expr);
		}
		
	}

	public class ParamNone_Expr<TInExpr>: ParamsExpr<ParamNone,TInExpr>
	{
		public ParamNone_Expr(ParamNone paramS, obj.expr.ExprI<TInExpr> expr
			
			)
			:base(paramS,expr)
		{

		}
		public ParamNone_Expr<TInExpr> apply(nilnul.obj.expr.ExprI<object> expr) {
 			return this;
		
		}
	}

	public class ParamPositive_Expr<TParamBase,TOther,TInExpr>
		:ParamsExpr<Params<TParamBase,TOther>,TInExpr>
		where TOther:ParamsI
	{
		public ParamPositive_Expr(
			Params<TParamBase,TOther> paramS
			,
			obj.expr.ExprI<TInExpr> expr
			
		):base(paramS,expr)
		{

		}
		public ParamsExpr<TOther, TInExpr> apply(nilnul.obj.expr.ExprI<TParamBase> expr) {
			return new ParamsExpr<TOther, TInExpr>( this.paramS.remaining,this.expr.substitute(paramS.var,expr ));
			
		}
	}


	public class AbstactionParams
	{
		static public Params<TInVar,TParams> Eval<TInVar, TParams>(obj.VarI3< TInVar> x, TParams parameters ) 
			where TParams:ParamsI
		
		{
			return new Params<TInVar, TParams>(x, parameters);
		
		}
		
	}

	public class Abstraction
	{

		
	}


	public class Compo
	{
		

		
	}



}
