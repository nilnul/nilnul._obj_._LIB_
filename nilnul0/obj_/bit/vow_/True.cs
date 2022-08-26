using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.bit.vow_
{

	
	//public class True<TXpn> :
	//	nilnul.obj_.Xpn<TXpn>
	//	,
	//	nilnul.obj_.bit.VowI
	//	where TXpn:Exception
	//{
	//	public True(TXpn val) : base(val)
	//	{
	//	}
		
	//	public void vow(bool obj)
	//	{
	//		if (!obj)
	//		{
	//			throws();
	//		};
	//	}
	//}

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
