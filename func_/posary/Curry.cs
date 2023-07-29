using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func_.posary
{
	/// <summary>
	/// binding some input to a value, such that the arity is increased.
	/// eg:
	///		var cup;
	///		fill(cup);
	/// // we can curry it:
	///		var cup=fill(); //where fill would return a cup, filled with coffee. the "fill()" would create a coffee, or get a cup you provided as a contextual shared variable|field;
	/// 
	/// </summary>
	internal class Curry
	{
	}
}
