using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_
{


	

	public class Started2<T, TTail>
		: StartedA1<T, TTail>
		,nilnul.ObjsI2<T>

		where TTail : nilnul.ObjsI2<T>

	{
		public Started2(T head, TTail tail) : base(head, tail)
		{
		}

		public T[] toArr()
		{

			return new[] { head }.Concat(tail.toArr()).ToArray();

			//throw new NotImplementedException();
		}
	}



}
