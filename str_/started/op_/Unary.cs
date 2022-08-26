using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_.started.op_
{
	/// <summary>
	/// taken in started, return a started.
	/// </summary>
	/// <typeparam name="TElement"></typeparam>
	public interface UnaryI<TElement>
		: nilnul.obj.op_.UnaryI<
			nilnul.objs_.StartedI2<TElement>
		>
		,
		nilnul.objs_.started.OpI<
			nilnul.objs_.StartedI2<TElement>
		>
	{
	}
}
