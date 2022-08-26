using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.be.vow_.xpN_._fail;

namespace nilnul.obj.be.vow_.xpN_.fail_.bE_
{

	[Obsolete(nameof(nilnul.obj.be.Vow4<T>))]

	public class Defaultable<T, TBe> :
		Fail<T, TBe>

		where TBe : nilnul.obj.BeI1<T>, new()

	{
		public Defaultable() : this( new FailException<T, TBe>())
		{
		}

		public Defaultable(FailException<T, TBe> xpn) : base(nilnul.obj_.Singleton<TBe>.Instance, xpn)
		{
		}

		public Defaultable( string msg) : this(new FailException<T,TBe>(msg) )
		{
		}


		static public Defaultable<T, TBe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Defaultable<T, TBe>>.Instance;
			}
		}

	}




}