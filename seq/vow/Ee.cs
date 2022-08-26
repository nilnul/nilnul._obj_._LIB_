using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq.vow
{
	public class Ee1<T, TVow> : nilnul.obj.vow.Ee1<IEnumerable<T>, TVow>
		where TVow : nilnul.obj.VowI2<IEnumerable<T>> //, nilnul.obj.seq.VowI<T>
	{
		public Ee1(IEnumerable<T> val, TVow vow) : base(val, vow)
		{
		}
	}


	public class Ee1<T> : Ee1<T, nilnul.obj.VowI2<IEnumerable<T>>>

	{
		public Ee1(IEnumerable<T> val, VowI2<IEnumerable<T>> vow) : base(val, vow)
		{
		}


	}


}
