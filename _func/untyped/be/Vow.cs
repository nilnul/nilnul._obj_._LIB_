using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._func.untyped.be
{
	public class Vow_ofLambda : nilnul.obj.be.Vow4<LambdaExpression>
		,
		untyped.VowI_ofLambda
	{
		public Vow_ofLambda(BeI1<LambdaExpression> be) : base(be)
		{
		}

		public Vow_ofLambda(Predicate<LambdaExpression> predicate) : base(predicate)
		{
		}

		public Vow_ofLambda(Func<LambdaExpression, bool> func) : base(func)
		{
		}
	}
}
