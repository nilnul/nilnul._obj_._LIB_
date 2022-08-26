using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit.vow_;
using nilnul.obj._vow;

namespace nilnul.obj.seq.vow_._plural
{


	public class VowTrue<T>
		:
		nilnul.obj_.bit.vow_.true_.xpN_.OfHeir<VowTrue<T>>
		,
		nilnul.obj.seq.VowI<T>
	{
		

		public VowTrue() : base("Must have 2 or more elements")
		{
		}

		public void vow(IEnumerable<T> obj)
		{
			base.vow(obj.Take(2).Count()>=2);
		}
	}
}
