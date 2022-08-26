using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// a block of code.
	/// given some storage place to use (for example, stack and heap given by  the runEnv)
	///		in procedure, we first declare some vars(container) with initial values(content).
	///		Then we can transition the state(all vers), statement by statement.
	///		
	/// </summary>
	/// <remarks>
	/// more complex than func.
	/// in procedure we can delcare var for func.
	/// body of a method; not including the signature of the method.
	/// vs
	///		class
	///			procedure is run in sequence whileas closure is only a data structure and how to run it is decided by caller.
	/// </remarks>
	/// alias:
	///		routine
	///		thunk
	///			past tense of think.
	public interface IProcedure
		:nilnul.obj.func.IContextual
	{
	}
	/*
	 move impure operations to the boundary of the system. //https://youtu.be/F9bznonKc64

	 */
}
