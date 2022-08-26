using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.accumulator_
{
	/// <summary>
	/// also works on set (for any order), so the premise is:
	///		1) the op is commutative
	///		2) the inital op another T, resulted in T
	///			2.1) this is commutative
	///				2.1.1) initial is the nilElement of the operator.
	///					.2.1.1.1. that is to say: the op has a nilElement
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TOp"></typeparam>
	///
	[Obsolete()]
	public interface AggregatorI<T, TOp>
		:AccumulatorI<T,TOp>
		where TOp : nilnul.obj.op_.binary_.CommutableI<T>
	{
		
	}

	
}
