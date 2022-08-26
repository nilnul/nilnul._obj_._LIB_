using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_
{
	public class Distinct<T, TEq> : nilnul.objs.be_.distinct.En<T, TEq>
		where TEq : IEqualityComparer<T>, new()
	{
		public Distinct(ObjsI2<T> val) : base(val)
		{
		}
	}
}
