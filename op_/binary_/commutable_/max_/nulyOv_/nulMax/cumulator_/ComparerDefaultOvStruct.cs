#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_.commutable_.max_.nulyOv_.nulMax.cumulator_
{
	public class CompDefaultOvStruct<T, TComparer>
		: CumulatorOvStruct<T>
		where TComparer : IComparer<T>, new()
		where T:struct
	{
		public CompDefaultOvStruct()
			:
			base( nilnul.obj_.Singleton<TComparer>.Instance)
		{
		}
	}
}
