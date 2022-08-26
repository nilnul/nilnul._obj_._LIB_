using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	



	public abstract class ReA<T>:ReI<T>
	{

		public abstract bool re(T a, T b);
		public  bool re((T, T) a) => re(a.Item1, a.Item2);

		public  bool re(Tuple<T, T> a) => re(a.Item1, a.Item2);

	}





	public abstract class ReA:ReI1
	{
		public const char SYMBOL = '⥽'; //fish tail U+297D

		public abstract bool re(object a, object b);
	}


}
