using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_.semigrp_.commutable
{
	public interface ICumulator :
		op_.binary_.semigrp.ICumulator
	{
	}

	public interface CumulatorI<out T, out TOp> : op_.binary_.semigrp.CumulatorI<T, TOp>
		where TOp : op_.binary_.semigrp_.CommutableI<T>
	{ }

	public interface CumulatorI< T>:CumulatorI<T, CommutableI<T>> { }

	public class Cumulator<T, TOp>
		:
		op_.binary_.semigrp.Cumulator<T, TOp>
		,
		CumulatorI<T, TOp>
		where TOp : op_.binary_.semigrp_.CommutableI<T>

	{
		public Cumulator(T initial, TOp binder) : base(initial, binder)
		{
		}
	}
	public class Cumulator<T> : Cumulator<T, CommutableI<T>>
	{
		public Cumulator(T initial, CommutableI<T> binder) : base(initial, binder)
		{
		}
	}
}
