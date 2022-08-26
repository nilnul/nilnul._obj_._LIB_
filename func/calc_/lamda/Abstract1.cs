using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace nilnul.obj.lambda
{
	public partial class Abstract1<TVar, TExpr>
	{
		

		public class Expr
		{

			private ParameterExpression _var;

			public ParameterExpression var
			{
				get { return _var; }
				set {
					Assert.True(
						value.Type==typeof(TVar)	
					);
					_var = value; 
				
				}
			}




			
			

		}
	}
}
