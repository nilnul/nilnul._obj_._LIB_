using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be._vow_
{
	public class OnArr<T> : nilnul.obj.be.Vow3<T[]>
	{
		public OnArr(obj.BeI1<T[]> be, Exception xpn) : base(be, xpn)
		{
		}

		public OnArr(obj.BeI1<T[]> be, string xpn) : base(be, xpn)
		{
		}
	}
	public class OnArr<T, TBe>
		:
		nilnul.obj.be.vow_.BeDefaultable<T[], TBe>
		where TBe : nilnul.obj.BeI1<T[]>,new()
	{
		public OnArr(Exception xpn) : base(xpn)
		{
		}

		public OnArr(string s) : base(s)
		{
		}
	}

}
