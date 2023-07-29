using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{


	/// <summary>
	/// var can be named according to a naming context. under different naming context, the name may vary.
	/// </summary>
	/// <remarks>
	/// int 1,   new object()  are both values;
	/// but in C#, we can create a var for latter using:
	///		var a=new object();
	///	we cannot straightforwardly create var for "1"; but in a tailored way:
	///		int a=1; // a is val, not var.
	///		ref int b=ref a;  //now b is a ref.
	/// </remarks>
	/// alias:
	///		ref
	///		refer
	///		reference
	///		val
	///			,which is what the var referred to;
	public  interface IVar
	{


	}

	public interface IVar<out T> : IVar {

	}
}
