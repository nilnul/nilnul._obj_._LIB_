using nilnul.obj.be._vow.xpn_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be
{
	public class VowOfRef<TObj> :
		nilnul.obj.BoxRef<nilnul.obj.BeOfRefI<TObj>>
		,
		nilnul.obj.Vow_ofRefI<TObj>
	{

		public VowOfRef(ref BeOfRefI<TObj> val) : base(ref val)
		{
		}

		public VowOfRef(BeOfRefI<TObj> x) : base(x)
		{
		}

		public void vow(ref TObj obj)
		{
			nilnul.bit.vow_._TrueX.Vow(
				boxed.be(ref obj)
				,
				new Negative1Exception<TObj>(boxed, obj)
			);

		}
	}
}
