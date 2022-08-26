using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border
{

	public class Eq<T, TEq, TBorder>
		: Eq<T,TBorder>
		where TEq : IEqualityComparer<T>, new()
		where TBorder : BorderI<T>
	{



		public Eq()
			:base(nilnul.obj_.Singleton<TEq>.Instance)
		{

		}
		
	}


}
