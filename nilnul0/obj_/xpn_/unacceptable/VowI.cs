using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.xpn_.unacceptable
{


	public class Vow : xpn.Vow<UnacceptableException>

	{
		public Vow(UnacceptableException xpn) : base(xpn)
		{
		}
		public Vow(string x):this(new UnacceptableException(x))
		{

		}
	}

}
