using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using s=System.Linq.Expressions;

using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda.be_
{

	/// <summary>
	/// the returned, or the body of the func, or the rule,  is of type
	/// </summary>
	public class Typed :
		nilnul.obj.Box1<Type>
		,
		func.calc_.lamda.BeI
	{
		public Typed(Type val) : base(val)
		{
		}

		public bool be(LambdaExpression obj)
		{
			
			return   this.boxed.IsAssignableFrom(obj.ReturnType);
		}

		

	}
}
