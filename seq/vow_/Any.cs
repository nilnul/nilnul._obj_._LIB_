using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.vow_;

namespace nilnul.obj.seq.vow_
{
	public class Any<T,TXpn>
		:
		nilnul.obj.Box<
		nilnul.bit.vow_.True<TXpn>
			>
		,
		nilnul.obj.seq.VowI<T>
		where TXpn:Exception
	{
		public Any(TXpn val) : base(new True<TXpn>(val))
		{
		}


		public void vow(IEnumerable<T> obj)
		{
			boxed.vow(obj.Any());
			
		}
	}

	public class Any<T> : Any<T, Exception>
	{
		public Any(string val) : base(new Exception(val))
		{
		}
	}
}
