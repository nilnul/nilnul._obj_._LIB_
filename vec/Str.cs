using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.vec
{
	/// <summary>
	/// vs:
	///		<see cref="str.IStrung"/>,
	///			vec implies being of the same size.
	///		so for vec.str, each component is of the same size.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	///
	//[Obsolete(nameof(matrix))]
	public interface StrI<T>: IEnumerable< IEnumerable<T>>
	{
	}
}
