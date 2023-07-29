using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border_.coop_
{
	public interface LowerI<T>:CoopI<T>
	{
	}


	public class Lower<T> : Border<T>,LowerI<T>
	{
		public Lower(bool openFalseCloseTrue, T mark) : base(openFalseCloseTrue, mark)
		{
		}
		public static Lower<T> CreateClose(T mark)
		{
			return new Lower<T>(true, mark);
		}
		public static Lower<T> CreateOpen(T mark)
		{
			return new Lower<T>(false, mark);
		}

	}
}
