using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	[Obsolete(nameof(expr_.Var))]
	public  class Var
		:VarI1

	{

		public override string ToString()
		{
			return nilnul.obj.var.set.NamingContext.Instance.getEnsuredName(this)??base.ToString();

			//return nilnul.obj.var.NamingContext1.StaticContext.getName(this)??base.ToString();
		}



		
	}
}
