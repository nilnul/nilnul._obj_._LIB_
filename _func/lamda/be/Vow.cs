using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._func.lamda.be
{
	public class Vow :
		nilnul.obj.be.Vow4<System.Linq.Expressions.LambdaExpression>
		,
		VowI
	{
		public Vow(BeI1<LambdaExpression> be) : base(be)
		{
		}

		public Vow(Predicate<LambdaExpression> predicate) : base(predicate)
		{
		}

		public Vow(Func<LambdaExpression, bool> func) : base(func)
		{
		}
	}
}
