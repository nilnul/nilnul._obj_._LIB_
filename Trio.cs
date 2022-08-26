using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{

	public class Trio<T>:Tuple<T,T,T>
	{
		public Trio(T a, T b, T c):base(a,b, c)
		{

		}
	}
}
