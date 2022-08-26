using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.be_.distinct.vow._en
{


	public class EqGeneric<T>
		: nilnul.obj.vow.Ed<nilnul.ObjsI2<T>, Vow<T, TEq>>
		where TEq:IEqualityComparer<T>

	{
		public En(ObjsI2<T> val) : base(val)
		{
		}
	}


}
