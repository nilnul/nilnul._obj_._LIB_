using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{


	/// <summary>
	/// var can be named according to a naming context. under different naming context, the name may vary.
	/// </summary>
	public  interface IVar
	{


	}

	public interface IVar<out T> : IVar {

	}
}
