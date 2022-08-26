using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.vow.en_
{
	public class OfArr<T,  TVow>
		:
		nilnul.obj.vow.En<T[], TVow>

		where TVow : nilnul.obj.str._vow_.OnArrI<T>, new()
	{
		public OfArr(T[] val) : base(val)
		{
		}
	}
}
