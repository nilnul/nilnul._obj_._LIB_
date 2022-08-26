using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	/// <summary>
	/// it can be a named variable, or an expression called anonymous variable containing named variables and literals.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// 
	[Obsolete(nameof(expr_.Var))]
	public interface VarI6<out T> 
		:
		
		IVar<T>
	{


	}
	[Obsolete(nameof(expr_.Var))]
	public class VarA6:IVar
	{

	}
	[Obsolete(nameof(expr_.Var))]
	public class Var6<T>:
		VarA6,
		VarI6<T>
	{

	}
	[Obsolete(nameof(expr_.Var))]

	public interface VarI6
		:VarI6<object>
	{

	}

	[Obsolete(nameof(expr_.Var))]

	public class Var6:Var6<object>,VarI6
	{

	}


	
}
