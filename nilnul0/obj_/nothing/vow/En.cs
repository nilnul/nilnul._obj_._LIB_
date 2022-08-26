using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.nothing.vow
{
	static public class _EnX
	{
		static public T En<T,X>(object obj, X xpn, T x)
			where X:Exception
		{
			Vow.Singleton.vow(obj,xpn);
			return x;
		}
		static public T En<T,X>(object obj, string xpn, T x)
			where X:Exception
		{
			Vow.Singleton.vow(obj,xpn);
			return x;
		}

		static public T En<T>(object obj, T x) {
			Vow.Singleton.vow(obj);
			return x;
		}



	}
}
