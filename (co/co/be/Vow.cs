using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co.be
{
	public class Vow<T>
		:
		nilnul.obj.be.VowOfRef<(T, T)>
	{
		public Vow(ref BeOfRefI<(T, T)> val) : base(ref val)
		{
		}

		public Vow(BeOfRefI<(T, T)> x) : base(x)
		{
		}
	}
}
