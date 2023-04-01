using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator.be_
{
	/// <summary>
	/// given any T,
	/// op(initial, any) = op(any,initial) = any.
	/// this doesnot imply Commutativity:
	///		for example, in Matrix, (e, multi)
	///
	/// the op, and the converse, is leftUnard.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// This is in common use whileas <see cref="INardable"/> is not useful;
	/// alias:
	///		neutral
	///		identity
	/// </remarks>
	public interface UnardableI<T>
		:nilnul.obj.op_.binary.cumulator.Be_cumulatorGeneriI<T>
	{
	}
}
