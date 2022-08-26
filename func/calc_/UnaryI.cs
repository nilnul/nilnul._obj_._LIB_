using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_
{
	public interface UnaryI:
		obj.func.CalcI
		,
		nilnul.obj.calc_.UnaryI<
			obj.FuncI3
		>
	{
	}



	
}
