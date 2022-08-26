using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._func.untyped.vow.ee_
{
	public class VowDefault_lambda< TVow> : obj._func.untyped.vow.Ee_lambda
		where TVow: VowI_ofLambda,new()
	{
		public VowDefault_lambda(LambdaExpression val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
		

	}
}
