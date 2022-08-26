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
	public interface IUnardable:ICumulator {

	}

	public interface UnardableI<T, TOp>
		:op_.binary.AccumulatorI<T,TOp>
		where TOp : nilnul.obj.op_.BinaryI<T>


	{

	}

	public interface UnardableI<T>
		:binary.AccumulatorI<T>
	{

	}

}
