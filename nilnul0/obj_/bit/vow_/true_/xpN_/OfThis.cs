using nilnul.obj._vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.bit.vow_.true_.xpN_
{
	public class OfThis :
		OfHeir< OfThis>
		,
		nilnul.obj_.bit.VowI

	{
		public OfThis(FailException<OfThis> xpn) : base(xpn)
		{
		}

		public OfThis(string s) : base(s)
		{
		}

		public OfThis()
		{
		}

		public override void vow(bool obj)
		{
			if (!obj)
			{
				this.boxed.Throw();
			}
		}

		static public OfThis Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<OfThis>.Instance;
			}
		}

	}
}
