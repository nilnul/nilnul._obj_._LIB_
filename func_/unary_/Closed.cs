using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func_.uni_
{
	public class Closed
		:
		func_.uni.be_.closed.vow.Ee
	{
		public Closed(Uni val) : base(val)
		{
		}

		public Closed(LambdaExpression p):this(new Uni(p) )
		{
		}
	}
}
