using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.enumable
{
	[Obsolete()]
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
