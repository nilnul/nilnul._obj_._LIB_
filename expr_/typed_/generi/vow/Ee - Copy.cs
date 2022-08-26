using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.typed_.generi.vow
{
	public class Ee<T> : nilnul.obj.vow.Ee1<GeneriI<T>>
	{
		public Ee(GeneriI<T> val, VowI2<GeneriI<T>> vow) : base(val, vow)
		{
		}
	}
}
