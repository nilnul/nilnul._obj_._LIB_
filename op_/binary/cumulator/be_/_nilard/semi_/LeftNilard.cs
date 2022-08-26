using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator.be_._nilard.semi_
{
	/// <summary>
	/// for <var>a</var> to be nilard,
	///		for any <var>x</var>, ax=a.
	/// </summary>
	/// <remarks>
	/// </remarks>
	public interface ILeftNilard:ISemiNilard
	{
	}

	public interface LeftNilardI<T>:ILeftNilard,SemiNilardI<T>
		,
		cumulator.Be_cumulatorGeneriI<T>
	{ }
}
