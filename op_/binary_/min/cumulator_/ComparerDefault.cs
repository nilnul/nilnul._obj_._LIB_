using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_.min.cumulator_
{
	public class ComparerDefault<T, TComparer>
		: Cumulator<T>
		where TComparer : IComparer<T>, new()
	{
		public ComparerDefault(T initial)
			:
			base(initial, nilnul.obj_.Singleton<TComparer>.Instance)
		{
		}
	}
}
