#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_.commutable_.max_.nulyOv_.nulMin.cumulator_
{
	public class ComparerDefault<T, TComparer>
		: Cumulator<T>
		where TComparer : IComparer<T>, new()
		where T:class?
	{
		public ComparerDefault()
			:
			base( nilnul.obj_.Singleton<TComparer>.Instance)
		{
		}
	}
}
