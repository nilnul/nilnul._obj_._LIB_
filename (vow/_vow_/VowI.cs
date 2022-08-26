using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._vow_
{
	public interface OfXpnI<T>
	{
		void vow<TXpn>(T obj, TXpn xpn)
			where TXpn:Exception
			;
	}

	
}
