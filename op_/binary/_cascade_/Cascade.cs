using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary._cascader_
{
	

	static public class _CascadeX
	{
		static public T Cascade_ofStarted<T, TOp>(this  IEnumerable<T> seq, TOp accumulator)
			where TOp : nilnul.obj.op_.BinaryI<T>
		{
			return seq.Aggregate(
				accumulator.op
			);
		}

		static public T Cascade_ofStarted<T>(this  IEnumerable<T> seq, nilnul.obj.op_.BinaryI<T> accumulator)
		{
			return seq.Aggregate(
				accumulator.op
			);
		}


	
	}


}
