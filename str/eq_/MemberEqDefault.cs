using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.eq_
{

	public class MemberEqDefault<T,TEq> :Eq<T>
		where TEq:IEqualityComparer<T>,new()
	{
		public MemberEqDefault():base( nilnul.obj_.Singleton<TEq>.Instance)
		{

		}

		static public MemberEqDefault<T,TEq> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<MemberEqDefault<T,TEq>>.Instance;
			}
		}

	}
}
