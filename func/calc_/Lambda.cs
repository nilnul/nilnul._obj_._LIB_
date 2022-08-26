using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace nilnul.obj.func.calc_
{
	

	/// <summary>
	/// we shall prefer using <see cref="System.Linq.Expressions.LambdaExpression"/> directly.
	/// </summary>
	public class Lamda :
		nilnul.obj.Box1<LambdaExpression>
		,
		LamdaI
	{
		public Lamda(LambdaExpression val) : base(val)
		{
		}

		public LambdaExpression lambda => this.boxed;

		public FuncI3 calc()
		{
			return LamdaX.FlattenAsFunc(this.lambda);
			//throw new NotImplementedException();
		}
	}


}