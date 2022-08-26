using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be.vow_.xpN_
{
	[Obsolete(nameof(nilnul.obj.be.Vow4<T>))]

	public class Fail<T,TBe> : 
		Vow3<
			T,TBe, nilnul.obj.be.vow_.xpN_._fail.FailException<T,TBe>
		>

		where TBe : nilnul.obj.BeI1<T>

	{
		public Fail(TBe be,obj.be.vow_.xpN_._fail.FailException<T,TBe> xpn  ) : base(be, xpn)
		{
		}
		public Fail(TBe be,string msg  ) : this(be, new _fail.FailException<T, TBe>(msg))
		{
		}

		public Fail(TBe be):this(be, new _fail.FailException<T, TBe>())
		{

		}
	}


}