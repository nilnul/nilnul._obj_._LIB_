using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.obj.var.withType.expr.members;

namespace nilnul.obj.var.withType.expr.op
{
	/// <summary>
	/// an op converted from obj.op
	/// </summary>
	/// <typeparam name="TArg"></typeparam>
	/// <typeparam name="TR"></typeparam>
	public partial class Unary<TArg,TR>
	{
		private nilnul.obj.op.UnaryI<TArg,TR> _op;

		public nilnul.obj.op.UnaryI<TArg,TR> op
		{
			get { return _op; }
			set { _op = value; }
		}
			
		public Unary(nilnul.obj.op.UnaryI<TArg,TR> op)
		{
			this.op = op;
		}

		public ExprI eval(ExprI a)
		{
			return new Call(op, a);
			throw new NotImplementedException();
		}

		public class Call
			:
			nilnul.obj.op.Call_OpArgA< nilnul.obj.op.UnaryI<TArg,TR>,ExprI>
			,
			ExprI
		{
			public Type type
			{
				get
				{
					return typeof(TR);
					throw new NotImplementedException();
				}
			}

			public Call( nilnul.obj.op.UnaryI<TArg,TR> op ,ExprI arg)
				:base(
				 
				 op,
				
				arg)
			{
				obj.type.rel.IsSubTypeOfX.Assert(
					arg.type, typeof(TR)
				);

			}
			
			public ExprI2<TR> substitute<V>( VarI2<V> var,ExprI2<V> expr)
			{

				throw new NotImplementedException();
			}

			public ExprI<TR> substitute<V>(VarI<V> var, ExprI<V> expr)
			{
				throw new NotImplementedException();
			}

			public ExprI<TR> demote()
			{

				throw new NotImplementedException();
			}

			ExprI demote()
			{
				var argDemoted=	this.arg.demote();
				if (argDemoted is FormI)
				{
					
				}

				throw new NotImplementedException();
			}

			public ExprI substitute(withType.VarI var, ExprI expr)
			{
				return new Call(this.op, this.arg.substitute(var, expr));
		
				throw new NotImplementedException();
			}
		}





	}
}
