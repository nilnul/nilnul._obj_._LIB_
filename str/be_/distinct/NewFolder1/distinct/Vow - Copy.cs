using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_.distinct
{
	[Obsolete()]
	public class Vow<T>
		: nilnul.obj.be.Vow<nilnul.obj.StrI1<T>>
	{
		public Vow(IEqualityComparer<T> eq) : base(new be_.Distinct1<T>(eq))
		{
		}
	}

	[Obsolete()]
	public class Vow<T,  TEq>
		: Vow<T>
		where TEq:IEqualityComparer<T>,new()
	{
		public Vow() : base( nilnul.obj_.Singleton<TEq>.Instance)
		{
		}
	}

	[Obsolete()]
	public class Vow_str<T,  TStr>
		:
		nilnul.obj.be.Vow<TStr>
		where TStr :nilnul.obj.StrI1<T>
	{
		public Vow_str(IEqualityComparer<T> eq) : base(new be_.Distinct_str<T,TStr>(eq))
		{
		}
	}

	[Obsolete()]
	public class Vow<T,  TEq, TStr>
		:
		nilnul.obj.be.Vow<TStr>

		where TEq:IEqualityComparer<T>,new()
		where TStr:nilnul.obj.StrI1<T>
	{

		public Vow() : base(
			new be_.Distinct1<T,TEq,TStr>(nilnul.obj_.Singleton<TEq>.Instance)
		)
		{
		}
	}


}
