using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.seq.be
{
	public interface VowI<TEle,TStr,TBe>:nilnul.obj.str_.seq.VowI<TEle,TStr>
		where TStr:nilnul.obj.str_.SeqI2<TEle>
		where TBe: nilnul.obj.str_.seq.BeI1<TEle,TStr>
	{
	}


	public class Vow<TEl,TStr,TBe>
		:
		nilnul.obj.be.vow_.xpN_.Fail<TStr,TBe>
		,
		VowI<TEl,TStr,TBe>
		where TBe: nilnul.obj.str_.seq.BeI1<TEl,TStr>
		where TStr:nilnul.obj.str_.SeqI2<TEl>


	{
		public Vow(TBe be) : base(be)
		{
		}

		public Vow(TBe be, string msg) : base(be, msg)
		{
		}

		public Vow(TBe be, FailException<TStr, TBe> xpn) : base(be, xpn)
		{
		}
	}
	public class Vow<TEl, TStr>
		:
		Vow<TEl, TStr, nilnul.obj.str_.seq.BeI1<TEl, TStr>>,

		VowI<TEl, TStr>
		where TStr : nilnul.obj.str_.SeqI2<TEl>

	{
		public Vow(BeI1<TEl, TStr> be) : base(be)
		{
		}

		public Vow(BeI1<TEl, TStr> be, string msg) : base(be, msg)
		{
		}

		public Vow(BeI1<TEl, TStr> be, FailException<TStr, BeI1<TEl, TStr>> xpn) : base(be, xpn)
		{
		}
	}

	
	[Obsolete()]
	public class Vow<TEl> :
		nilnul.obj.be.vow_.xpN_.fail_.bE_.General<nilnul.obj.str_.SeqI2<TEl>>
		,
		nilnul.obj.str_.seq.VowI<TEl>

	{
		public Vow(obj.BeI1<SeqI2<TEl>> be) : base(be)
		{
		}

		public Vow(obj.BeI1<SeqI2<TEl>> be, string msg) : base(be, msg)
		{
		}

		public Vow(obj.BeI1<SeqI2<TEl>> be, FailException<SeqI2<TEl>, obj.BeI1<SeqI2<TEl>>> xpn) : base(be, xpn)
		{
		}
	}
	


}
