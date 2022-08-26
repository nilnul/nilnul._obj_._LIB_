using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_.max
{
	public class Cumulator<T>
		:
		binary.Cumulator<T>
	{
		public Cumulator(T initial, IComparer<T> comparer)
			:
			base(
				initial,
				new binary_.commutable_.Max<T>(comparer)
			)
		{
		}
	}
}
