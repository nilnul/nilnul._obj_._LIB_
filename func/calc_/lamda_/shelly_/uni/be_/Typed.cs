using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using s=System.Linq.Expressions;

using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda_.uni.be_
{

	/// <summary>
	/// the returned, or the body of the func, or the rule,  is of type
	/// </summary>
	public class Typed :
		nilnul.obj.Box1<nilnul.obj.func.calc_.lamda.be_.Typed>
		,
		func.calc_.lamda_.uni.BeI
	{
		public Typed(Type val) : base(new func.calc_.lamda.be_.Typed(val) )
		{
		}


		

		public bool be(shelly_.Uni obj)
		{

			return boxed.be( obj.ee );
		}
	}
}
