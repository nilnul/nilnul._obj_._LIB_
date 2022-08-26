using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._bound
{
	public interface LowerI<T>
		:nilnul.obj.BorderI<T>
	{
	}

	public abstract class LowerA<T>
		:
		Border<T>
		,
		LowerI<T>
	{
		

		public LowerA(bool openFalseCloseTrue, T mark):base(openFalseCloseTrue,mark)
		{
		}
	}

}
