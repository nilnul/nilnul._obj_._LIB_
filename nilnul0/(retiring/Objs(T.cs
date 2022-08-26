using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{

	[Obsolete()]
	public class Objs<T> :

		nilnul.obj.Box<T[]>,
		nilnul.ObjsI2<T>
	{
		public Objs(T[] val) : base(val)
		{


		}

		public T[] toArr()
		{
			return boxed;
			throw new NotImplementedException();
		}


	}


}
