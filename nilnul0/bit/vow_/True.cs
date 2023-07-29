using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.vow_
{

	[Obsolete(nameof(obj_.bit.vow_._TrueX))]
	static public class _TrueX{
		static public void Vow<TXpn>(bool obj, TXpn xpn)
			where TXpn:Exception
		{
			if (!obj)
			{
				throw xpn;
			}
		}
	}
	[Obsolete(nameof(obj_.bit.vow_.True<TXpn>))]
	public class True<TXpn> :
		nilnul.obj_.Xpn<TXpn>
		,
		nilnul.bit.VowI
		where TXpn:Exception
	{
		public True(TXpn val) : base(val)
		{
		}
		
		public void vow(bool obj)
		{
			if (!obj)
			{
				throws();
			};
		}
	}

	[Obsolete(nameof(obj_.bit.vow_.True))]
	public class True : True<Exception>
	{
		public True(string val) : base(new Exception(val))
		{
		}
		public True():this("")
		{

		}

		static public True Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<True>.Instance;
			}
		}

	}

}
