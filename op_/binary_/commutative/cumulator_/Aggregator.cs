using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_.commutative.cumulator_
{
	public interface AggregatorI<T, TOp>
		:
		obj.op_.binary_.commutative.CumulatorI<T, TOp>
		where TOp : nilnul.obj.op_.binary_.CommutableI<T>
	{
	}

	public class Aggregator<T, TOp> : obj.op_.binary_.commutative.Cumulator<T, TOp>
		where TOp : nilnul.obj.op_.binary_.CommutableI<T>

	{
		public Aggregator(T initial, TOp binder) : base(initial, binder)
		{
		}
	}

	public class Aggregator_opDefault<T, TOp>

	{

	}
}
