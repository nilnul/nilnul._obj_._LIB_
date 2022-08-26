using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{

	public class Objs_arr<T> :

		nilnul.obj.Box1<T[]>
		,
		nilnul.ObjsI3<T>
	{
		public Objs_arr(T[] val) : base(val)
		{
			
		}

		public Objs_arr(IEnumerable<T> tail):this(tail.ToArray())
		{
		}

		public IEnumerator<T> GetEnumerator()
		{
			foreach (var item in boxed)
			{
				yield return item;
			}
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
