using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_
{

	
	public class Empty1<T> : EmptyI, nilnul.ObjsI2<T>
	{
		public T[] toArr()
		{
			return new T[0];
			//throw new NotImplementedException();
		}
	}


}
