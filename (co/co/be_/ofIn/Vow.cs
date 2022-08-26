using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co.be_.ofIn
{
	public class Vow<T>
		:
		nilnul.obj.be.Vow_ofIn<(T, T)>
	{
		public Vow(in BeI_ofIn<(T, T)> val) : base(in val)
		{
		}

		public Vow(BeI_ofIn<(T, T)> x) : base(x)
		{
		}
	}
}
