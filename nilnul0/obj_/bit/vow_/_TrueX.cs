using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.bit.vow_
{
	[Obsolete(nameof(nilnul.bit.vow_._TrueX))]
	static public class _TrueX
	{
		static public void Vow<TXpn>(bool bit, TXpn xpn)
			where TXpn: Exception
		{
			if (!bit)
			{
				throw xpn;
			}
		}
		static public void Vow(bool bit, string xpn=null)
		{
			Vow<Exception>(bit,new Exception(xpn));
		}


	}
}
