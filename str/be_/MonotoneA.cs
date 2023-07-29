using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_
{
	public abstract class MonotoneA<TEl>
		:
		nilnul.obj.Box_ofIn<obj.co.str.every.be_.CompI<TEl>>
		,
		MonotoneI<TEl>
	{
		public MonotoneA(in obj.co.str.every.be_.CompI<TEl> val) : base(val)
		{
		}

		public MonotoneA(obj.co.str.every.be_.CompI<TEl> x) : base(x)
		{
		}



		public bool be(IEnumerable<TEl> obj)
		{
			return boxed.be(
				nilnul.obj.co.seq.of_.els_._PeekAheadX.Cos(obj)
			);

		}
	}
}
