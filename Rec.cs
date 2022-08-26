using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// a str (hence finite) of components, each of which is of a subtype of Obj, and that's why we put <see cref="nameof(rec_)"/> under the namespace <see cref="nameof(obj)"/>
	///		
	/// </summary>
	/// <remarks>
	///	vs:
	///		Str
	///			the type of components can vary whileas the type of components of str must be the same.
	/// 
	/// rec is defined after obj_.subtype. hence we can define Op.
	/// 
	/// </remarks>
	/// rec
	/// row
	public interface IRec
	{
	}


}
