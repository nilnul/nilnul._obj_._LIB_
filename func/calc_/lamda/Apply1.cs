using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.lambda
{
	public partial class Apply1<TDomain, TMiddle, TRange>
	{






		public class Expr : LambdaI1<TDomain, TRange>
		{
			private LambdaI1<TDomain, TMiddle> _op;
			public LambdaI1<TDomain, TMiddle> op
			{
				get { return _op; }
				set { _op = value; }
			}

			private LambdaI1<TMiddle, TRange> _operand;
			public LambdaI1<TMiddle, TRange> operand
			{
				get { return _operand; }
				set { _operand = value; }
			}

			public Expr(

				LambdaI1<TDomain, TMiddle> op
								,
				LambdaI1<TMiddle, TRange> operand

			)
			{

				this.op = op;
				this.operand = operand;

			}

		}
	}
}
