using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda.be
{

	public class Vow
		:
		nilnul.obj.be.Vow4<
			LambdaExpression
		>
		,
		func.calc_.lamda.VowI
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
