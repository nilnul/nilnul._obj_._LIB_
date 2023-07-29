using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border.co
{
	public abstract class BeA<T,TBorder>
		:
		BeI<T,TBorder>
		where TBorder: nilnul.obj.BorderI<T>
	{
		public abstract bool be(in (TBorder,TBorder) obj);
		public bool be( (TBorder,TBorder) obj)
		{
			return be(in obj);
		}


	


	}
}
