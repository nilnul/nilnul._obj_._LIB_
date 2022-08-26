using nilnul.obj.be._vow.xpn_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be
{
	public class Vow_ofIn<TObj> :
		nilnul.obj.Box_ofIn<nilnul.obj.BeI_ofIn<TObj>>
		,
		nilnul.obj.VowI_ofIn<TObj>
	{

		public Vow_ofIn(in BeI_ofIn<TObj> val) : base(in val)
		{
		}

		public Vow_ofIn(BeI_ofIn<TObj> x) : base(x)
		{
		}

		public void vow(in TObj obj)
		{
			nilnul.bit.vow_._TrueX.Vow(
				boxed.be(in obj)
				,
				new Negative1Exception<TObj>(boxed, obj)
			);

		}
	}
}
