using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.seq.be_.distinct.vow_
{
	

	public class EqDefault<T,  TEq>
		: Vow<T>
		where TEq:IEqualityComparer<T>,new()
	{
		public EqDefault() : base( nilnul.obj_.Singleton<TEq>.Instance)
		{
		}
	}




}
