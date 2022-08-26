using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be
{
	[Obsolete()]
	public class Vow<T,TStr> : nilnul.obj.be.vow_.xpN_.fail_.bE_.General<TStr>
	{
		public Vow(obj.BeI1<TStr> be) : base(be)
		{
		}

		public Vow(obj.BeI1<TStr> be, string msg) : base(be, msg)
		{
		}

		public Vow(obj.BeI1<TStr> be, FailException<TStr, obj.BeI1<TStr>> xpn) : base(be, xpn)
		{
		}
	}

	[Obsolete()]
	public class Vow<T> : nilnul.obj.be.vow_.xpN_.fail_.bE_.General<nilnul.obj.StrI2<T>>
	{
		public Vow(obj.BeI1<StrI2<T>> be) : base(be)
		{
		}

		public Vow(obj.BeI1<StrI2<T>> be, string msg) : base(be, msg)
		{
		}

		public Vow(obj.BeI1<StrI2<T>> be, FailException<StrI2<T>, obj.BeI1<StrI2<T>>> xpn) : base(be, xpn)
		{
		}
	}

}
