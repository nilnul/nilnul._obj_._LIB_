using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.set.assign.duo.be_
{
	public class SameVars<T>
		:nilnul.obj.duo.be_.FroEq<
			
			nilnul.obj.var.set.State<T>
			,
			nilnul.obj.var.set.assign.eq_.SameVars<T>
		>
	{

		public class En
			:
			nilnul.obj.duo.be.En<
				nilnul.obj.var.set.State<T>,
				SameVars<T>
			>
		{
			public En(
				Tuple<var.set.State<T>, var.set.State<T>> val
			) : base(val)
			{
			}

		
		}
	}
}
