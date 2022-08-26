using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using s=System.Linq.Expressions;

using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.be_
{

	/// <summary>
	/// the returned, or the body of the func, or the rule,  is of type
	/// </summary>
	public class Typed :
		nilnul.obj.Box1<Type>
		,
		func.BeI
	{
		public Typed(Type val) : base(val)
		{
		}


		public bool _be_assumeFlat(LambdaExpression obj)
		{
			
			return   this.boxed.IsAssignableFrom(obj.ReturnType);
		}

		public bool be(FuncI3 obj)
		{
			return _be_assumeFlat(obj.flat);
			//throw new NotImplementedException();
		}
	}
}
