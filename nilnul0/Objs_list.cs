using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{

	public class Objs_list<T> :

		nilnul.obj.Box1<List<T>>
		,
		nilnul.ObjsI3<T>
	{
		public Objs_list(List<T> val) : base(val)
		{
			
		}

		public IEnumerator<T> GetEnumerator()
		{
			return boxed.GetEnumerator();
			//return boxed.GetEnumerator();
			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			//throw new NotImplementedException();
		}
	}


}
