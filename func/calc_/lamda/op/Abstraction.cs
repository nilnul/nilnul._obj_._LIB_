using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace nilnul.obj.lambda.op
{
	public partial class Abstraction<TVar, TExpr>
		where TExpr:LambdaI
		
	{
		

		public class Call:LambdaI<TVar,TExpr>
		{

			private nilnul.obj.VarI2<TVar> _var;

			public nilnul.obj.VarI2<TVar> var
			{
				get { return _var; }
				set {
					
					_var = value; 
				
				}
			}

			private TExpr _expr;

			public TExpr expr
			{
				get { return _expr; }
				set { _expr = value; }
			}
			






			
			

		}
	}
}
