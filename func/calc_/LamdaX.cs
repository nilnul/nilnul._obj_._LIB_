using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace nilnul.obj.func.calc_
{
	

	/// <summary>
	/// </summary>
	static public class LamdaX  
	{
		static public LambdaExpression Flatten(LambdaExpression x) {
			if (nilnul.obj._expr.expr0lamda.be_.Nonlamda.Singleton.be(x.Body))
			{
				return x;
			}
			// body is lambda
			var bodyFlattened = Flatten( (LambdaExpression) (x.Body) );

			return LambdaExpression.Lambda(
				x.Body
				,
				x.Parameters.Concat(bodyFlattened.Parameters)
			);

		}

		static public obj.Func3 FlattenAsFunc(LambdaExpression x) {
			return new nilnul.obj.Func3( Flatten(x) );

		}



 



	}


}