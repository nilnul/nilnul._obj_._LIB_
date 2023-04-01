using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._vow_
{
	public abstract class XpnA<T>
		:nilnul.obj.Box<T>
		where T:Exception
	{
		//private T _xpn;
		//public T xpn
		//{
		//	get { return _xpn; }
		//	set { _xpn = value; }
		//}

		public XpnA(T xpn):base(xpn)
		{
			//this._xpn = xpn;
		}

		//public override string ToString()
		//{
		//	return _xpn.ToString();
		//}

	}

}
