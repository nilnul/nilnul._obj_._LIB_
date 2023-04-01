using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border
{

	public abstract class CompA<T, TBorder> : IComparer<TBorder>
		where TBorder : BorderI<T>
	{
		public abstract int Compare(TBorder x, TBorder y);
		//public  int Compare(TBorder x, T y) {
			
		//}
	}
}
