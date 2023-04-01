using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.vow_._none;

namespace nilnul.obj.vow_.true_.xpn_
{
	public class Unacceptable : True<_none.UnacceptableException>
	{
		
		public Unacceptable(string s):this(new UnacceptableException(s))
		{
		}

		public Unacceptable(UnacceptableException xpn) : base(xpn)
		{
		}
	}
}
