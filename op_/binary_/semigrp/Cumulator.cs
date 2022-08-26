using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_.semigrp
{
	public interface ICumulator :
		op_.binary.ICumulator
	{
	}

	public interface CumulatorI<out T, out TOp> : op_.binary.CumulatorI<T, TOp>
		where TOp : op_.binary_.SemigrpI<T>
	{ }

	public interface CumulatorI< T>:CumulatorI<T, SemigrpI<T>> { }

	public class Cumulator<T, TOp>
		:
		op_.binary.Cumulator<T, TOp>
		,
		CumulatorI<T, TOp>
		where TOp : op_.binary_.SemigrpI<T>

	{
		public Cumulator(T initial, TOp binder) : base(initial, binder)
		{
		}
	}
	public class Cumulator<T> : Cumulator<T, SemigrpI<T>>
	{
		public Cumulator(T initial, SemigrpI<T> binder) : base(initial, binder)
		{
		}
	}
}
