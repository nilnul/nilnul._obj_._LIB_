using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.vec.eq_
{
	public class ElEqDefaulted<TEle,TElEq> : 
		Eq<TEle>
		where TElEq:IEqualityComparer<TEle>,new()
	{
		public ElEqDefaulted():base(nilnul.obj_.Singleton<TElEq>.Instance)
		{
		}

		static public ElEqDefaulted<TEle, TElEq> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<ElEqDefaulted<TEle, TElEq>>.Instance;
			}
		}


	}
}
