using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._border_.at.comp_
{
	[Obsolete(nameof(nilnul.bit.comp.Converse))]
	public class Lower : IComparer<bool>
	{
		public int Compare(bool x, bool y)
		{
			return nilnul.bit.co.minus._NegX.Int(x, y);
		}

		static public Lower Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Lower>.Instance;
			}
		}

	}
}
