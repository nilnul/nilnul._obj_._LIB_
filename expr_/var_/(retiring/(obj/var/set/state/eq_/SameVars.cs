using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.set.assign.eq_
{
	public class SameVars<T>
		:
		nilnul.obj.eq.EqFroEq<var.Set1, var.set.Eq, nilnul.obj.var.set.State<T>>,
		nilnul.obj.var.set.assign.EqI<T>
	{
		public SameVars( ) : base(setAssign=>setAssign.vars)
		{
		}

		
	}
}
