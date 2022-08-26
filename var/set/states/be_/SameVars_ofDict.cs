using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.set.states.be_
{
	public class SameVars_ofDict<T>
		:
		nilnul.objs.be_.Equiv<
			nilnul.obj.var.set.State_heritDict<T>
			,
			nilnul.obj.var.set.state.eq_.SameVars_ofDict<T>
		>
		,
		nilnul.obj.var.set.states.BeI_ofDict<T>
	{

		static private Lazy<SameVars_ofDict<T>> _Lazy = new Lazy<SameVars_ofDict<T>>();
		static public SameVars_ofDict<T> Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

		public class En : nilnul.obj.var.set.states.be.En_ofDict<T, SameVars_ofDict<T>>
		{
			public En(IEnumerable<State_heritDict<T>> val) : base(val)
			{
			}
		}

	}
}
