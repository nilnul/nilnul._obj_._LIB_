using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._bound
{
	public interface UpperI<T>
		:nilnul.obj.BorderI<T>
	{
	}

	public abstract class UpperA<T>
		:
		Border<T>
		,
		UpperI<T>
	{
		

		public UpperA(bool openFalseCloseTrue, T mark):base(openFalseCloseTrue,mark)
		{
			
		}
	}
}
