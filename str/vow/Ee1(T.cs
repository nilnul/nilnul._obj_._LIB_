using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.vow
{
	public class Ee1<T>
		:
		Ee1<T, IEnumerable<T>>

	{
		public Ee1(IEnumerable<T> val, obj.VowI2<IEnumerable<T>> vow) : base(val, vow)
		{
		}
	}




}
