using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using s=System.Linq.Expressions;

using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._expr.untyped.be_
{

	public class OfType :
		nilnul.obj.Box1<Type>
		,
		untyped.BeI
		//nilnul.obj.BeI1<System.Linq.Expressions.Expression>
	{
		public OfType(Type val) : base(val)
		{
		}

		public bool be(UntypedI obj)
		{
			
			return obj.lambda.ee.Type == this.boxed;
			///throw new NotImplementedException();
		}

		

	}
}
