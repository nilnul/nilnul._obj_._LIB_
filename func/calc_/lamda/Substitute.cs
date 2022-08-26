using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace nilnul.obj.lambda
{
	public partial class Substitute
	{

		static public Expression Eval(Expression expr,ParameterExpression para, Expression another) {


 
			///visit and replace
			///


			ExpressionVisitor visitor = new ExpressionVisitor();

			throw new NotImplementedException();
		
		}

		static public LambdaI1<TDomain, TRange> Eval<TDomain,TRange>(

			LambdaI1<TDomain,TRange> lambda
			,

			Var<TDomain,TRange> var,


			LambdaI1<TDomain,TRange> newLambda

			
		) {




			throw new NotImplementedException();
		
		
		}



	}
}
