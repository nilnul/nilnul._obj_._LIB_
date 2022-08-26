using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border.co.be
{
	public class Vow<T,TBorder>
		:
		nilnul.obj.be.Vow_ofIn<(TBorder,TBorder)>
		,
		co.VowI<T,TBorder>
		where TBorder: obj.BorderI<T>
	{
		public Vow(in BeI_ofIn<(TBorder,TBorder)> val) : base(in val)
		{
		}

		public Vow(BeI_ofIn<(TBorder,TBorder)> x) : base(x)
		{
		}
	}
}
