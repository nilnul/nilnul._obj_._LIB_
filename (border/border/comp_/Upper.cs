using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border.comp_
{
	public class Upper<T, TBorder> :
		nilnul.obj.Box<IComparer<T>>
		,
		IComparer<TBorder>
		where TBorder:BorderI<T>
	{
		public Upper(IComparer<T> val) : base(val)
		{
		}

		public int Compare(TBorder x, TBorder y)
		{
			var compared = boxed.Compare(x.mark, y.mark);
			if ( compared !=0)
			{
				return compared;
			}
			return _border_.at.comp_.Upper.Singleton.Compare(x.openFalseCloseTrue,y.openFalseCloseTrue);

		}
	}
}
