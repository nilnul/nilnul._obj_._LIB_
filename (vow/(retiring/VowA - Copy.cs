using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	public abstract class VowA<T, TXpn> :
		VowI<T>
		where TXpn:Exception
	{
		private TXpn _xpn;

		public TXpn xpn
		{
			get { return _xpn; }
			set { _xpn = value; }
		}

		public VowA(TXpn xpn)
		{
			_xpn = xpn;
		}

		public abstract void vow(T obj);
	}
}
