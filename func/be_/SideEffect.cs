using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.be_
{
	/// <summary>
	/// calls of the func might return the same value. But during the process, the func might change the state of the env.
	/// eg:
	///		writing database.
	///			you might alwarys return void.
	/// </summary>
	class SideEffect
	{
	}
}
