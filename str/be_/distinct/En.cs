using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.be_.distinct
{
	public class En<T, TEq>
		: nilnul.obj.be.En1<nilnul.ObjsI2<T>, Distinct<T, TEq>>
		where TEq:IEqualityComparer<T>,new()

	{
		public En(ObjsI2<T> val) : base(val)
		{
		}
	}
}
