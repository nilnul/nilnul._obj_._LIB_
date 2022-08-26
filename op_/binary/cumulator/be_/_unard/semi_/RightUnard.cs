using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator.be_._unard.semi_
{
	/// <summary>
	/// the initial is at the right, when op-ed with a term from the str; and the result is the term, for it to be any instance of its type.
	/// this is equivalent to say that:
	///		the converse of the op with the initial is leftUnard.
	/// </summary>
	/// <remarks>
	/// </remarks>
	public interface IRightUnard
	{
	}

	public interface RightUnardI<T> : IRightUnard
	,cumulator.Be_cumulatorGeneriI<T>{ }
}
