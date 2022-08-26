using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.set.state.eq_
{
	public class SameVars_ofDict<T>
		:
		nilnul.obj.eq.EqFroEq<
			IEnumerable<VarI5<T>>,
			var.set.EqOfEnumerable<T>,
			nilnul.obj.var.set.State_heritDict<T>>
		,
		nilnul.obj.var.set.state.EqI_ofDict<T>
	{
		public SameVars_ofDict( ) : base(state=>state.Keys)
		{
		}


		static private Lazy<SameVars_ofDict<T>> _Lazy = new Lazy<SameVars_ofDict<T>>();
		static public SameVars_ofDict<T> Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}



	}
}
