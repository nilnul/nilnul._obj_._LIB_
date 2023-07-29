using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.expr.op
{
	public partial class Binary<TArg,TArg1,TR>
		:nilnul.obj.op.BinaryI<ExprI2<TArg>,ExprI2<TArg1>,ExprI2<TR>>
	{
		private nilnul.obj.op.BinaryI<TArg,TArg1,TR> _op;

		public nilnul.obj.op.BinaryI<TArg,TArg1,TR> op
		{
			get { return _op; }
			set { _op = value; }
		}
		

			
		public Binary(nilnul.obj.op.BinaryI<TArg,TArg1,TR> op)
		{
			this.op = op;

		}


		public class Expr
			:
			nilnul.obj.op.Call_OpArgArg1A< nilnul.obj.op.BinaryI<TArg,TArg1,TR>,ExprI2<TArg>,ExprI2<TArg1>>
			,
			nilnul.obj.ExprI2<TR>
		{


			public Expr( nilnul.obj.op.BinaryI<TArg,TArg1,TR> op ,ExprI2<TArg> arg, ExprI2<TArg1> arg1)
				:base(
				 op,
				arg
				,
				arg1
				)
			{

			}
			
			public ExprI2<TR> substitute<V>( VarI2<V> var,ExprI2<V> expr)
			{
				return new Expr(this.op, this.arg.substitute(var, expr), this.arg1.substitute( var,expr));

				throw new NotImplementedException();
			}
		}







		public ExprI2<TR> eval(ExprI2<TArg> a, ExprI2<TArg1> b)
		{

			return new Expr(this.op, a, b);
			throw new NotImplementedException();
		}
	}
}
