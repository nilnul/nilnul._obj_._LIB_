using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_
{
	/// <summary>
	/// not only the pars are of the same type, but also the return type
	/// </summary>
	///
	public interface IClosed { }
	public interface ClosedI
		:
		_op_.BlankI

	{
	}

	public interface ClosedI<T>
		:
		ClosedI
		,
		nilnul.obj._op_.RetI<T>

	{
	}



}
