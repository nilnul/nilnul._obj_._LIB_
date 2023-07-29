using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co.be.vow_
{
	public class OfIn<T>
		:
		nilnul.obj.be.Vow_ofIn<(T, T)>
	{
		public OfIn(in BeI_ofIn<(T, T)> val) : base(in val)
		{
		}

		public OfIn(BeI_ofIn<(T, T)> x) : base(x)
		{
		}
	}
}
