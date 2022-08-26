using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator.be_._unard.semi_
{
	/// <summary>
	/// the initial is at the left, when op-ed with a term from the str; and the result is the term, for it to be any instance of its type.
	/// </summary>
	/// <remarks>
	/// </remarks>
	public interface ILeftUnard
	{
	}

	public interface LeftUnardI<T>:ILeftUnard
		,
		cumulator.Be_cumulatorGeneriI<T>
	{ }
}
