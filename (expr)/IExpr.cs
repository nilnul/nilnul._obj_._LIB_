using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{

	/// <summary>
	/// vs: <see cref="nameof(System.Linq.Expressions.Expression)"/>
	///		Expression is of various type parameter, hence closed if we abstract the type parameter as an object type.
	/// </summary>
	/// <remarks>
	/// we may need to implement out own as in <see cref="nameof(System.Linq.Expressions.Expression)"/>, 1+a is not valid until it's used inside funciton body. 
	/// </remarks>
	public  interface IExpr
	{
	}

	
}
