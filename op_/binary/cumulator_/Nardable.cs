using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator_
{
	/// <summary>
	/// the initial is a nard.
	/// for example, (0,*)
	/// excluding:
	///		(0,+), as 0 is unard (not nard) for "+"
	/// </summary>
	/// alias:
	///		anoid
	///			like monoid
	public interface INardable
		:
		ICumulator
		//,
		//obj.algebra_.pargoid_.magma_.semigrp_.IMonoid //the el is not unard, so this is not monoid. instead, this is anoid
	{

	}

	public interface NardableI<T, TOp>
		:op_.binary.CumulatorI<T,TOp>
		where TOp : nilnul.obj.op_.BinaryI<T>


	{

	}

	public interface NardableI<T>
		:NardableI<T,nilnul.obj.op_.BinaryI<T> >
	{

	}

}
