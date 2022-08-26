using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be.vow_.xpn_
{
	[Obsolete(nameof(nilnul.obj.be.Vow4<T>))]

	public class Unacceptable<T,TBe, TVow> : 
		Vow3<T,TBe, nilnul.obj_.xpn_.UnacceptableException< TVow>>

		where TBe : nilnul.obj.BeI1<T>
		where TVow: nilnul.obj._vow_.BlankI

	{
		public Unacceptable(TBe be,obj_.xpn_.UnacceptableException<TVow> xpn  ) : base(be, xpn)
		{
		}
		public Unacceptable(TBe be,string msg  ) : this(be, new obj_.xpn_.UnacceptableException<TVow>(msg))
		{
		}

		public Unacceptable(TBe be):this(be, "")
		{

		}
	}


}