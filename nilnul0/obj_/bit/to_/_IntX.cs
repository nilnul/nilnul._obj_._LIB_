using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.to_
{
	public class Int : nilnul.obj._to_.ToI<bool, int>
	{
		public int to(bool src)
		{
			return src ? 1 : 0;
		}


		static public Int Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Int>.Instance;
			}
		}

	}
}
