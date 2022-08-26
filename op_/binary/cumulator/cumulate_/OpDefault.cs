using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator.cumulate_
{

	public class OpDefault<T, TOp>
		: Cumulate<T>

		where TOp : nilnul.obj.op_.BinaryI<T>, new()
	{
		public OpDefault(T initial) : base(
			 new binary.cumulator_.OpDefault<T,TOp>(initial)
		)
		{
		}
	}
	




}
