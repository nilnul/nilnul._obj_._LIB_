using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_
{
	public class List<T>
		:
		System.Collections.Generic.List<T>
		,
		nilnul.ObjsI1<T>
	{

		public List(IEnumerable<T> objs):base(objs)
		{

		}
		
	}
}
