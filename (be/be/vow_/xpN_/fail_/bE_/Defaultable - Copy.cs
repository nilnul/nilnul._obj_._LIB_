using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be.vow_.xpn_.unacceptable_.be_
{

	[Obsolete(nameof(nilnul.obj.be.Vow4<T>))]

	public class Defaultable<T, TBe, TVow> : 
		Unacceptable<T,TBe,  TVow>

		where TBe : nilnul.obj.BeI1<T>,new()
		where TVow: nilnul.obj.VowI<T>

	{
		public Defaultable( obj_.xpn_.UnacceptableException<TVow> unacceptable):base(nilnul.obj_.Singleton<TBe>.Instance,  unacceptable)
		{

		}
		public Defaultable(string msg  ) : base( nilnul.obj_.Singleton<TBe>.Instance, (msg))
		{
		}


		public Defaultable():this( "")
		{

		}
	}


	

}