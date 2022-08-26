using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.assign.eq_
{
	public class SameVar<T> : 
		nilnul.obj.eq.EqFroEq<nilnul.obj.VarI1, nilnul.obj.var.Eq1, Assignment<T>>
		,
		assign.EqI<T>
	{
		public SameVar() : base(assign=>assign.var)
		{


		}

		 
	}
}
