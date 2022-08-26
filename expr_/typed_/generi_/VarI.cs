using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.typed_.generi_
{
	/// <summary>
	/// call_.
	/// </summary>
	///
	public interface VarI<T>:
		nilnul.obj.expr_.typed_.GeneriI<T>
		,
		IVar
		,
		nilnul.obj.expr_.VarI

	{
	}
}
