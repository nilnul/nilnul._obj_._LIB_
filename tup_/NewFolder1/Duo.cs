using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.tup_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"> subtype of the base type: here obj</typeparam>
	/// <typeparam name="T1">subtype of the base type: here it's obj</typeparam>
	/// <remarks>
	///	vs Co:
	///		the type in Co must be the same.
	/// </remarks>
	///
	[Obsolete(nameof(tup_.IDuo))]
	public interface DuoI<T,T1>
	{
	}
}
