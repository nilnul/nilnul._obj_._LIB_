using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.procedure_.unpure.to_.pure_
{
	/// after all, functin, pure or unpure, always returns something, which is added to the environment.
	/// So adding something shall be acceptable.
	/// 
	/// <summary>
	/// we can convert an unpure procedure to a pure one by utilizing some datastructure like:
	///		tree.
	///	Thus instead of changing data, we can change structure.
	///	Eg:
	///		rather than return a new array [1,2,4] from [1,2,3]
	///		we can return a new tree, which references the [1,2] from [1,2,3], and the [4], which is newly created (that is an incremental change to the environment.).
	/// </summary>
	/// <remarks>
	/// eg:
	///		in repository, we use link to instead of a copy of other files.
	/// </remarks>
	class ByStruc
	{
	}
}
