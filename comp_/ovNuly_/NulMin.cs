using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.comp_.ovNuly_
{
	
	public class NulMin<T>
		:
		nilnul.obj.Box1<IComparer<T>>
		,
		OvNulyI<T>
	{
		public NulMin(IComparer<T> val) : base(val)
		{
		}

		public int Compare(T x, T y)
		{
			if (x is null)
			{
				if (y is null)
				{
					return 0;
				}
				return -1;

			}
			if (y is null)
			{
				return 1;
			}
			return boxed.Compare(x, y);
			//throw new NotImplementedException();
		}
	}
}
