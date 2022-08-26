using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be.vow_
{
	public class BeDefault<T, TBe> : nilnul.obj.str.be.Vow<T>
		where TBe : nilnul.obj.str.BeI2<T>, new()
	{
		public BeDefault() : base(nilnul.obj_.singleton_.Lazy<TBe>.Instance)
		{
		}

		public BeDefault( string msg) : base(nilnul.obj_.singleton_.Lazy<TBe>.Instance, msg)
		{
		}

		public BeDefault( FailException<StrI2<T>, obj.BeI1<StrI2<T>>> xpn) : base(nilnul.obj_.singleton_.Lazy<TBe>.Instance, xpn)
		{
		}
	}
}
