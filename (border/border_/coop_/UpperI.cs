using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border_.coop_
{
	public interface UpperI<T>:CoopI<T>
	{
	}

	public class Upper<T> : Border<T>,UpperI<T>
	{
		public Upper(bool openFalseCloseTrue, T mark) : base(openFalseCloseTrue, mark)
		{
		}
		public static Upper<T> CreateClose(T mark) {
			return new Upper<T>(true, mark);
		}
		public static Upper<T> CreateOpen(T mark) {
			return new Upper<T>(false, mark);
		}
	}
}
