using nilnul.obj.be.vow_.xpN_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be
{


	[Obsolete()]
	public class En3<T, TBe>
	:
	nilnul.obj.vow.Ee1<T, nilnul.obj.be.vow_.xpN_.Fail<T, TBe>>

	where TBe : nilnul.obj.BeI1<T>
	{
		public En3(T val,  Fail<T, TBe> vow) : base(val, vow)
		{
		}

		public En3(T obj,   TBe be) : base(obj, new Fail<T, TBe>(be) )
		{
		}

	}

	[Obsolete()]
	public class En3<T> : En3<T, nilnul.obj.BeI1<T>>
	{
		[Obsolete( )]
		public En3(T val, Fail<T, BeI1<T>> vow) : base(val, vow)
		{
		}

		public En3(T obj, BeI1<T> be) : base(obj, be)
		{
		}
	}

}
