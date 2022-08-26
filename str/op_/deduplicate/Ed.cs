using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.op_.deduplicate
{

	public class Ed<T, TEq> : nilnul.obj.op.Ed2<nilnul.ObjsI2<T>, nilnul.objs.op_.Deduplicate<T, TEq>>
		where TEq:IEqualityComparer<T>,new()
	{
		public Ed(ObjsI2<T> input) : base(input)
		{
		}
	}
}
