using nilnul.obj.be._vow.xpn_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be
{
	public class Vow4<TObj> :
		nilnul.obj.Box1<nilnul.obj.BeI1<TObj>>
		,
		nilnul.obj.VowI2<TObj>
	{
		

		public Vow4(BeI1<TObj> be):base(be)
		{
		}
		public Vow4(Predicate<TObj> predicate):this(
				new nilnul.obj.Be1<TObj>(predicate)
		)
		{

		}

		public Vow4(Func<TObj,bool>  func):base(new nilnul.obj.Be1<TObj>( func))
		{

		}

		public void vow(TObj obj)
		{
			nilnul.bit.vow_._TrueX.Vow(
				boxed.be(obj)
				,
				new NegativeException<TObj>(boxed, obj)
			);
		}
	}
}
