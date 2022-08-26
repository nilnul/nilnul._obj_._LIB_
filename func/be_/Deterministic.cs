using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.be_
{
	/// <summary>
	/// calls of the func doesnot return the same value.
	/// thus it's no cacheable.
	/// eg:
	///		reading database.
	///			the database is not part of this function.
	/// </summary>
	class Deterministic
	{
	}
}
