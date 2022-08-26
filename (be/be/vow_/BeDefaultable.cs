using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be.vow_
{

	[Obsolete()]
	public class BeDefaultable<T, TBe, TXpn> : 
		Vow3<T,TBe,  TXpn>

		where TBe : nilnul.obj.BeI1<T>,new()
		where TXpn: Exception

	{
		public BeDefaultable(TXpn msg  ) : base( nilnul.obj_.Singleton<TBe>.Instance, (msg))
		{
		}

	}

	public class BeDefaultable<T,TBe> : BeDefaultable<T,  TBe,Exception>
		where TBe : nilnul.obj.BeI1<T>,new()
	{
		public BeDefaultable( Exception xpn) : base( xpn)
		{
		}

		public BeDefaultable(string s=""):this(new Exception(s))
		{
		}
		


	}





}