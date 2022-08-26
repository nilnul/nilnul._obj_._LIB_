using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.vec
{
	public interface ICo {

	}
	/// <summary>
	/// vs:
	///		<see cref="str.ICo"/>,
	///			vec implies being of the same size.
	///		so for vec.co, each component is of the same size.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface ICo<T>
		:
		obj.ICo<IEnumerable<T>>
		,
		ICo
	{
	}
}
