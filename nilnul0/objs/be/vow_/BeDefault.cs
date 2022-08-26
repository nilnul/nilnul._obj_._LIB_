using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.be.vow_
{
	public class BeDefault<TObj, TBe>
		: nilnul.objs.be.Vow_ovObj<TObj>
		where TBe : nilnul.obj.BeI1<nilnul.ObjsI3<TObj>>, new()
	{
		public BeDefault() : base(nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance)
		{
		}


		static public BeDefault<TObj, TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeDefault<TObj, TBe>>.Instance;
			}
		}

	}
}
