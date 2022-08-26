#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_.commutable_.max_.nulyOv_.nulMin
{
	/*
	 * 
	 T? to just mean "defaultable" in the unconstrained case, not "nullable". I think that was a really stupid move as it leads to exactly the confusion you're in right now. But yeah: in C#, T? doesn't always mean nullable
	 */

	public class CumulatorOvStruct<T>
		:
		binary.Cumulator<T?>
		where T:struct
		
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="comparer"></param>
		public CumulatorOvStruct( IComparer<T> comparer)
			:
			base(
				null,
				new binary_.commutable_.max_.nulyOv_.NulMinOvStruct<T>(comparer)
			)
		{
		}
	}
}
