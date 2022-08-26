using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_
{
	/// <summary>
	/// 
	/// each <see cref="System.Linq.Expressions.LambdaExpression"/> is regarded as <see cref="ICalc"/>. If the lambda.body is not lambda, it's converted to a parameterless lambda.
	///
	/// the recursion here is about layers, not about appending pars. At each layer, we may have multipar func.
	///
	/// <see cref="System.Linq.Expressions.LambdaExpression"/> has no <see cref="calc_.unary_.Apply"/>.
	/// </summary>
	/// <remarks>
	/// alias:
	///		lamda
	///			"b" is intentionally ommited. to:
	///				make it shorter
	///				make it evading the name used by sys.
	///				make it distinguishable when being searched and replaced.
	///					this increases the entropy
	///
	/// </remarks>
	public interface ILamda
		:ICalc
	{
	}
}
