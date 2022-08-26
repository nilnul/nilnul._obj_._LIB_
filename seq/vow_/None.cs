using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.vow_;

namespace nilnul.obj.seq.vow_
{
	public class None<T,TXpn>
		:
		nilnul.obj.Box<
		nilnul.bit.vow_.True<TXpn>
			>
		,
		nilnul.obj.seq.VowI<T>
		where TXpn:Exception
	{
		public None(TXpn val) : base(new True<TXpn>(val))
		{
		}


		public void vow(IEnumerable<T> obj)
		{
			boxed.vow(obj.None());
			
		}
	}

	public class None<T> : None<T, Exception>
	{
		public None(string val) : base(new Exception(val))
		{
		}
	}
}
