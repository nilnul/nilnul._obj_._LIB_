using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._border_.at.comp_
{
	public class Upper : IComparer<bool>
	{
		public int Compare(bool x, bool y)
		{
			return nilnul.bit.co._MinusX.Int(x, y);
		}

		static public Upper Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Upper>.Instance;
			}
		}

	}
}
