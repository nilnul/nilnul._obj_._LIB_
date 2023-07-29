using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using s=System.Linq.Expressions;

using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr.be_
{

	/// <summary>
	/// the returned, or the body of the func, or the rule,  is of type
	/// </summary>
	public class Typed :
		nilnul.obj.Box1<Type>
		,
		expr.BeI
	{
		public Typed(Type val) : base(val)
		{
		}


		public bool _be_assumeNonlamd(Expression obj)
		{
			
			return   this.boxed.IsAssignableFrom(obj.Type);
		}

		public bool be(ExprI4 obj)
		{
			return _be_assumeNonlamd(obj.expr);
			//throw new NotImplementedException();
		}
	}
}
