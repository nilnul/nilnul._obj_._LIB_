using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using s=System.Linq.Expressions;

using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func_.closed.be_
{

	/// <summary>
	/// the returned, or the body of the func, or the rule,  is of type
	/// </summary>
	public class Typed :
		nilnul.obj.Box1<nilnul.obj.func.be_.Typed>
		,
		func_.closed.BeI
	{
		public Typed(Type val) : base(new func.be_.Typed(val) )
		{
		}


		

		public bool be(Closed obj)
		{

			return boxed.be( obj.ee );
		}
	}
}
