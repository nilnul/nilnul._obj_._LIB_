using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._identy
{
	/// <summary>
	/// This is used in <see cref="nilnul.txt_.Versioned.nomina"/>
	/// eg:
	///		nilnul.abc.def
	///			in nilnul.abc.def2
	///		nilnul.abc.def.Gh_
	///			in nilnul.abc.def.Gh_3
	///		nilnul.abc.def.IGh_
	///			in nilnul.abc.def.IGh_3
	///		nilnul.abc.def.IGhA
	///			in nilnul.abc.def.IGhA32
	///		nilnul.abc1.def.IGhA
	///			in nilnul.abc1.def.IGhA32
	///			
	///			
	/// </summary>
	public interface INomina
	{
	}
}
