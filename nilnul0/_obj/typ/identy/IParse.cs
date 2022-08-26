using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ.identy
{
	/// <summary>
	/// eg:
	/// 
	///		nilnul.abc32.def.Www456
	///			the nomina is: nilnul.abc32.def.Www
	///				note "32" is in the nomina
	///			the version is 456
	///			
	///		nilnul.abc32.def.Www456.789.222.555.333
	///			the nomina is: nilnul.abc32.def.Www
	///				note "32" is in the nomina
	///			the version is 456.789.222.555.333
	///			
	///		nilnul.abc32.def.Www.456.789.222.555.333
	///			the nomina is: nilnul.abc32.def.Www.
	///				note
	///					'.' is at the end
	///						which is unnecessary, and harmful thus shall be removed.
	///					"32" is in the nomina
	///			the version is 456.789.222.555.333
	///		
	/// </summary>
	class IParse
	{
	}
}
