using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.set.assigns.be_
{
	public class SameVars<T>
		:
		nilnul.objs.be_.Equiv<
			nilnul.obj.var.set.State<T>
			,
			nilnul.obj.var.set.assign.eq_.SameVars<T>
		>
		,
		nilnul.obj.var.set.assigns.BeI<T>
	{

		public class En : nilnul.obj.var.set.assigns.be.En<T, SameVars<T>>
		{
			public En(IEnumerable<State<T>> val) : base(val)
			{
			}
		}

	}
}
