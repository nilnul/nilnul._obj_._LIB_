using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_.semigrp_.commutable.cumulator_
{
	/// <summary>
	/// if the initial is unard(not nard); eg: 0, with +. 1 with *
	/// </summary>
	public interface IMonoid:ICumulator
	{
	}
	public interface MonoidI<out T, out TOp>
		: CumulatorI<T, TOp>
		where TOp: semigrp_.CommutableI<T>

	{ }


}
/*
 The name "monad" came from "monoid" and "triad", which indicated that it is a triple (1 functor + 2 trasformations), monoidic algebraic structure.

In other words, monoid is a more general, abstract term. When applying it to the category of endofunctors, we have a monad.
 */
