using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// given a natural number,
	///		a rec  of that length. 
	///		
	/// </summary>
	/// <remarks>
	/// alias:
	///		tuple
	///	vs:
	///		Rec
	///			common: the type of each component can vary.
	///			diff: the length of rec is dynamic; whileas the length of tup is preset.
	/// 
	/// </remarks>
	public interface ITup:IRec
	{
	}
}
