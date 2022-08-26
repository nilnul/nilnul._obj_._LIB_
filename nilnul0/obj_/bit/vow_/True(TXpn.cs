using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.bit.vow_
{
	//[Obsolete(nameof(nilnul.bit.vow_.True<TXpn>))]
	public class True< TXpn>
		:
		nilnul.obj.VowA1<bool,TXpn>
		where TXpn : Exception
	{
		public True(TXpn xpn ):base(xpn)
		{

		}
		public override void vow(bool obj)
		{
			if (!obj)
			{
				this.boxed.Throw();
			}
		}

		

	}
}
