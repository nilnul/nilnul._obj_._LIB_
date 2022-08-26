using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda_.uni_.closed_.generi.op_
{
	public interface BinaryI<T>
		:
		nilnul.obj.op_.BinaryI<
			Generi<T>
		>
		,
		func.calc_.lamda_.uni_.closed_.generi.op_.IOf<T>
	{

	}
}
