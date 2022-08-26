using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be.vow_.be_
{

	[Obsolete(nameof(nilnul.obj.be.Vow4<T>))]
	public class Defaultable<T, TBe, TXpn> : 
		Vow3<T,TBe,  TXpn>

		where TBe : nilnul.obj.BeI1<T>,new()
		where TXpn: Exception

	{
		public Defaultable(TXpn msg  ) : base( nilnul.obj_.Singleton<TBe>.Instance, (msg))
		{
		}

		
	}


	

}