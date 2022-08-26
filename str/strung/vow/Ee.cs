using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.strung.vow
{
	public class Ee<T>
		:
		nilnul.obj.str.vow.Ee1<
			IEnumerable<T>
		>
	{
		public Ee(IEnumerable<IEnumerable<T>> val, obj.VowI2<IEnumerable<IEnumerable<T>>> vow) : base(val, vow)
		{
		}
	}
}
