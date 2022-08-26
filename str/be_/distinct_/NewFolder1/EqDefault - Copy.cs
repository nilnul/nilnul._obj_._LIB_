using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_.distinct_
{

	[Obsolete()]
	public class EqDefault<T,  TEq>
		: 
		Distinct2<T >
		where TEq : IEqualityComparer<T>, new()
	{
		public EqDefault() : base(nilnul.obj_.singleton_.Lazy<TEq>.Instance)
		{
		}
	}


	[Obsolete()]
	public class EqDefault<T,  TEq, TStr>
		: 
		Distinct2<T,TStr >
		,
		nilnul.obj.str.BeI2<T,TStr>

		where TEq : IEqualityComparer<T>, new()
		where TStr: nilnul.obj.StrI2<T>
	{
		public EqDefault() : base(nilnul.obj_.singleton_.Lazy<TEq>.Instance)
		{
		}

		
	}



}
