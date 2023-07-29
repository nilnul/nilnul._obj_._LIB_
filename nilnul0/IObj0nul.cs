using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{
	/// <summary>
	/// for reference type, T such as object, it can mean a null.
	/// for value type, T, we have to use T? such as int?
	/// </summary>
	/// alias:
	///		Ref0nul
	///	vs:
	///		<see cref="nilnul.obj_.IRef0nul"/>
	public interface IObj0nul
		:obj.INulable
	{
	}
}
