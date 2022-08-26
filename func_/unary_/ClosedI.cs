using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func_.uni_
{
	/// <summary>
	/// </summary>
	/// <remarks>
	/// </remarks>
	public interface IClosed:obj.func_.IUni
	{
	}
	public interface ClosedI
		:IClosed
		,
		IUni
		,
		FuncI3
	{ }



	
}
