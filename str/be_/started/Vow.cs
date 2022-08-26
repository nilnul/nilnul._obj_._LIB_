using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_.started
{
	public class Vow<T>
		: nilnul.obj.str.be._vow_.OnArr<T, nilnul.obj.str.be_.Started<T>>
		,
		nilnul.obj.str._vow_.OnArrI<T>
	{
		public Vow(Exception xpn) : base(xpn)
		{
		}

		public Vow(string s) : base(s)
		{
		}

		public Vow():this($"The array must be non-empty")
		{

		}
	}


}
