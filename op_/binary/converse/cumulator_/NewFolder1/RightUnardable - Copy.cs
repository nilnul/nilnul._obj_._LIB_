using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator_
{
	/// <summary>
	/// the initial is a unard
	/// </summary>
	///
	[Obsolete(nameof(binary.converse.cumulator))]

	public interface IRightUnardable:ICumulatorRight {

	}

	[Obsolete(nameof(binary.converse.cumulator))]


	public interface RightUnardableI<T, TOp>
		:op_.binary.CumulatorRightI<T,TOp>
		where TOp : nilnul.obj.op_.BinaryI<T>


	{

	}

	[Obsolete(nameof(binary.converse.cumulator))]

	public interface RightUnardableI<T>
		:binary.CumulatorRightI<T>
		,
		RightUnardableI<T, nilnul.obj.op_.BinaryI<T>>
	{

	}

}
