using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.seq
{

	[Obsolete(nameof(seq.eq_.ElEqDefaulted<TEle,TElEq>))]
	public class Eq<TEle,TElEq> : 
		Eq<TEle>
		where TElEq:IEqualityComparer<TEle>,new()
	{
		public Eq():base(nilnul.obj_.Singleton<TElEq>.Instance)
		{
		}

		static public Eq<TEle, TElEq> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq<TEle, TElEq>>.Instance;
			}
		}


	}
}
