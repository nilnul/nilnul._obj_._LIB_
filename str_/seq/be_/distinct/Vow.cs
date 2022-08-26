using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.seq.be_.distinct
{

	public class Vow<T,TStr>
		: nilnul.obj.str_.seq.be.Vow<T,TStr>
		where TStr: nilnul.obj.str_.SeqI2<T>

	{
		public Vow(IEqualityComparer<T> eq) : base(new be_.Distinct1<T,TStr>(eq))
		{
		}

	

		public Vow(IEqualityComparer<T> eq, string msg) : base(new be_.Distinct1<T,TStr>(eq), msg)
		{
		}

		public Vow(IEqualityComparer<T> eq, FailException<TStr, obj.str_.seq.BeI1<T,TStr>> xpn) : base(new be_.Distinct1<T,TStr>(eq), xpn)
		{
		}
	}


	public class Vow<T>
		: nilnul.obj.str_.seq.be.Vow<T>
	{
		public Vow(IEqualityComparer<T> eq) : base(new be_.Distinct1<T>(eq))
		{
		}

	

		public Vow(IEqualityComparer<T> eq, string msg) : base(new be_.Distinct1<T>(eq), msg)
		{
		}

		public Vow(IEqualityComparer<T> eq, FailException<SeqI2<T>, obj.BeI1<SeqI2<T>>> xpn) : base(new be_.Distinct1<T>(eq), xpn)
		{
		}
	}


}
