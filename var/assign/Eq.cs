using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.assign
{
	public class Eq<T>
		:
		nilnul.obj.duo.eq_.EqFroComponents<nilnul.obj.VarI1, T,nilnul.obj.var.Assignment<T>>
		,
		nilnul.obj.var.assign.EqI<T>
	{

		public Eq( IEqualityComparer<T> valEq ) : base(
			nilnul.obj.var.Eq1.Instance
			,
			valEq
			,
			(assign)=> new Tuple<VarI1, T>(assign.var,assign.val)

		)
		{

		}
	}
}
