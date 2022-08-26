using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_.started
{


	/// <summary>
	///  return a started. the input is not restricted here.
	/// </summary>
	/// <typeparam name="TElement">type of the element, not the container</typeparam>
	public interface IOp<TElement>
		:nilnul.obj.IOp<nilnul.objs_.StartedI2<TElement>>
	{

	}
	public interface OpI<TElement>
		:nilnul.obj.OpI3<nilnul.objs_.StartedI2<TElement>>
		,
		IOp<TElement>
	{

	}
}
