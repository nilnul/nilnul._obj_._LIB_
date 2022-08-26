using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.lambda
{
	public partial class Apply<TOpDomain,TOpRange,TOp2Range>
	{




		public class Expr:LambdaI1<TOpDomain,TOp2Range>
		{
			private  TOpDomain _lambda;

			public TOpDomain lambda
			{
				get { return _lambda; }
				set { _lambda = value; }
			}

			private TOpRange _expr;

			public TOpRange expr
			{
				get { return _expr; }
				set { _expr = value; }
			}

			public Expr()
			{

			}


			
			
			
		}

	}
}
