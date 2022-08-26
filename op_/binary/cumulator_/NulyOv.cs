#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator_
{
	public class NulyOv<T>
		:
		binary.Cumulator<T?>
		where T : notnull
	{
		public NulyOv(T? initial, BinaryI<T?> accumulator) : base(initial, accumulator)
		{
		}
	}
}
