using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.duo.convert_
{
	public class Converse
	{
		static public Duo<T> Eval<T>(Duo<T> x)  {
			return new Duo<T>(x.Item2,x.Item1);
		}

		static public Tuple<T, T> Eval<T>(Tuple<T,T> x) {
			return new Tuple<T, T>(x.Item2,x.Item1);
		}
	}
}
