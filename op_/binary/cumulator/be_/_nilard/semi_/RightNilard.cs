using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator.be_._nilard.semi_
{
	/// <summary>
	/// for <var>a</var> to be nilard,
	///		for any <var>x</var>, xa=a
	/// </summary>
	/// <remarks>
	/// </remarks>
	public interface IRightNilard:ISemiNilard
	{
	}

	public interface RightNilardI<T> : IRightNilard,SemiNilardI<T>
	,cumulator.Be_cumulatorGeneriI<T>{ }
}
