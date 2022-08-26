using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc
{
	/// <summary>
	/// flatten the pars of the calc, resulting a literal one-level func.
	/// </summary>
	/// <remarks>
	/// vs:partial/binding
	///		binding means feed an arg and eliminite one par. It's application <see cref="func.op_.unary_._ProvisionX"/>. The result is another func. Func to func.
	///		curry means unflatten, making it curly. uncurry means flatten, uncurling it.
	///		Uncurry means changing calc to func. By differentiating <see cref="ICalc"/> and <see cref="IFunc"/>, we made the <see cref="Uncurry"/> explicit and straight. calc to func.
	/// </remarks>
	class Uncurry
	{
	}
}
