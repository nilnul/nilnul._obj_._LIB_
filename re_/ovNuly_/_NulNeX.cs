#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re_.ovNuly_
{
	

	static public class _NulNeX
		

	{
		
		static public bool Re<T>(IEqualityComparer<T> boxed,  T? x, T? y)
		{
			if (x is null)
			{
				if (y is null)
				{
					return false;
				}
				return false;
			}
			if (y is null)
			{
				return false;
			}
			return boxed.Equals(x, y);
			//throw new NotImplementedException();
		}

	
	}


}
