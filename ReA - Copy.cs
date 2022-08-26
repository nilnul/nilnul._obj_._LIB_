using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	



	public abstract class ReA<T,T1>:ReI<T,T1>
	{

		public abstract bool re(T a, T1 b);
		public  bool re((T, T1) a) => re(a.Item1, a.Item2);

		public  bool re(Tuple<T, T1> a) => re(a.Item1, a.Item2);

	}




}
