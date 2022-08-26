using nilnul.obj._vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.bit.vow_.true_.xpN_
{
	public class OfHeir<THeirVow> :
		nilnul.obj.Vow_xpnOfHeirA<bool, THeirVow>
		,
		nilnul.obj_.bit.VowI

		where THeirVow : nilnul.obj._vow_.BlankI
	{
		public OfHeir(FailException<THeirVow> xpn) : base(xpn)
		{
		}

		public OfHeir(string s) : base(s)
		{
		}

		public OfHeir()
		{
		}

		public override void vow(bool obj)
		{
			if (!obj)
			{
				this.boxed.Throw();
			}
		}

		static public OfHeir<THeirVow> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<OfHeir<THeirVow>>.Instance;
			}
		}

	}
}
