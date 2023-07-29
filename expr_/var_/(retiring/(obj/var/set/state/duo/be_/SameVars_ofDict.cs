using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.set.assign.duo.be_
{
	public class SameVars_ofDict<T>
		:nilnul.obj.duo.be_.FroEq<
			
			nilnul.obj.var.set.State_heritDict<T>
			,
			nilnul.obj.var.set.state.eq_.SameVars_ofDict<T>
		>
	{

		public class En
			:
			nilnul.obj.duo.be.En<
				nilnul.obj.var.set.State_heritDict<T>,
				SameVars_ofDict<T>
			>
		{
			public En(
				Tuple<var.set.State_heritDict<T>, var.set.State_heritDict<T>> val
			) : base(val)
			{
			}

		
		}
	}
}
