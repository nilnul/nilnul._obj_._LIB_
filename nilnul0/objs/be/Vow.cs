using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.be
{
	public class Vow_ovObj<TObj>
		: nilnul.obj.be.Vow4<nilnul.ObjsI3<TObj>>
		,
		nilnul.objs.VowI1<TObj>
	{
		public Vow_ovObj(obj.BeI1<ObjsI3<TObj>> be) : base(be)
		{
		}

		public Vow_ovObj(Predicate<ObjsI3<TObj>> predicate) : base(predicate)
		{
		}

		public Vow_ovObj(Func<ObjsI3<TObj>, bool> func) : base(func)
		{
		}
	}
}
