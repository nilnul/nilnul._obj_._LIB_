using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.dict_
{
	/// <summary>
	/// in parent type, this is already defined.
	/// </summary>
	/// <typeparam name="TKey"></typeparam>
	/// <typeparam name="TVal"></typeparam>
	/// <typeparam name="TEq"></typeparam>
	public class EqDefault<TKey, TVal, TEq>
		:nilnul.obj.Dict<TKey,TVal,TEq>
	{
	}
}
