using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.enumerable.b;
using nilnul.obj._form;
using nilnul.obj._form._members;
using nilnul.obj.call._call;
using nilnul.obj.var;
using nilnul.obj.var.stati;
using nilnul.obj.expr;
using nilnul.obj._tuple._call;
using nilnul._expr;
using nilnul.var;
using nilnul._call;
using nilnul._op;

namespace nilnul.expr
{
	public class Call<T>
		: Call<nilnul.OpI<T>, T>
	{

		public Call(nilnul.OpI<T> op, nilnul.ExprI_membered<T> arg) : base(op, arg)
		{

		}


	}


	public class Call<TOp, T>

		:
		Call<TOp, T, T>
		where TOp : nilnul.OpI<T>

	{
		public Call(TOp op, nilnul.ExprI_membered<T> arg) : base(op, arg)
		{

		}



	}

	public class Call<TOp, TR, TP>
		:
		Call<TOp, TR, TP, nilnul.ExprI_membered<TP>>

		,
		ExprI_membered<TR>

		where TOp : nilnul.OpI<TP, TR>

	{

		public Call(TOp op, nilnul.ExprI_membered<TP> arg) : base(op, arg)
		{

		}


	




	}
	/// <summary>
	/// the mono op call
	/// </summary>
	/// <typeparam name="TOp"></typeparam>
	/// <typeparam name="TR"></typeparam>
	/// <typeparam name="TP"></typeparam>
	/// <typeparam name="TExpr"></typeparam>

	public class Call<TOp, TR, TP, TExpr>
		:
		nilnul._call.Call_OpArgA<TOp, TExpr>
		,
		nilnul.ExprI_membered<TR>
		//,nilnul._call.OpI<TOp>
		,nilnul._expr.VarsI

		where TOp : nilnul.OpI<TP, TR>
		where TExpr : nilnul.ExprI_membered<TP>	//,nilnul._expr.VarsI

	{

		public Call(TOp op, TExpr arg) : base(op, arg)
		{

		}

	
	

		public Set_ofVarI vars
		{
			get
			{
				return arg.vars;

				throw new NotImplementedException();
			}
		}

		_op.OpI_generic _call.OpI<_op.OpI_generic>.op
		{
			get
			{
				return this.op;
				throw new NotImplementedException();
			}
		}

		public ExprI_membered<TR> reduce()
		{

			var argReduced = arg.reduce();

			if (argReduced is no._call.EvalI<TP>)
			{
				var casted = argReduced as no._call.EvalI<TP>;
				return new no.Call<TR>(op.eval(
					casted.eval()
				));

			}
			else
			{
				return new Call<TOp, TR, TP>(
					op, argReduced
				);
			}


			throw new NotImplementedException();
		}

		public ExprI_membered<TR> substitute<V>(VarI1<V> var, ExprI_membered<V> expr)
		{
				var argSubsituted = arg.substitute<V>(var, expr);
						return new Call<TOp, TR, TP>(
							op, argSubsituted
						);


			throw new NotImplementedException();
		}

		

		

		
	}


}
