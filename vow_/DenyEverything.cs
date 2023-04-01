using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.vow_
{
	/// <summary>
	/// in fact, an exception
	/// </summary>
	static public class _DenyEverythingX
	{
		static public void Vow_throwGivenException<T>(T xpn)
			where T:Exception
		{
			throw xpn;

		}
		


	}
}
