using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.expr.op.unary
{
		public partial class Call<P,R>
			:
			nilnul.obj.op.Call_OpArgA<obj.op.UnaryI<P,R>,ExprI<P>>
			,
			ExprI<R>
		{
			public Call(
				obj.op.UnaryI<P,R> op
				,
				ExprI<P> arg
			)
				:base(op,arg)
			{

			}


			public ExprI<R> substitute<V>(VarI3<V> var, ExprI<V> expr)
			{
				return new Call<P,R>(op, arg.substitute(var, expr));

				//throw new NotImplementedException();
			}

			public ExprI<R> demote()
			{
				var argDemoted = arg.demote();

				if (argDemoted is CallI)
				{
					return new Call<R> ( 

						new nilnul.obj.call.op.unary.Call<P,R>(
						
							op, 
							
							(argDemoted as Call<P>).call
						)
						
					);
					
				}
				
				return new Call<P,R> ( 

						
						
							op, 
							
							argDemoted
						
						
					);
				throw new NotImplementedException();
			}
		}
	}
