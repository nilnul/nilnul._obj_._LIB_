using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.set.assign.interpret.eq_
{
	public class SameVars<TInVar, TRet>
		:
		nilnul.obj.eq.EqFroEq< 
			nilnul.obj.var.set.State<TInVar> 
			,
			nilnul.obj.var.set.assign.eq_.SameVars<TInVar>
			,
			nilnul.obj.var.set.assign.Interpret<TInVar,TRet>
		>
		,
		nilnul.obj.var.set.assign.interpret.EqI<TInVar, TRet>
	{
		public SameVars(System.Func<Interpret<TInVar, TRet>, State<TInVar>> mapping) : base(
			interpret=>interpret.assign	
		)
		{
		}

	}
}
