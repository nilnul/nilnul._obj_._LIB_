using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func.input.compo
{
	public interface FirstI
	{
	}

	public interface FirstI<T> : FirstI {
		nilnul.obj.VarI3<T> var { get; }

		CallI remaining { get; }

	}
}
