using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_
{
	public class ListEnumerator<T>:List<T>
		,nilnul.obj.StrI<T>

	{

		private List<T> _list;

		public List<T> list
		{
			get { return _list; }
			set { _list = value; }
		}

		public ListEnumerator(List<T> list)
		{
			_list = new List<T>(list);

		}


		public  nilnul.obj.StrI<T> asStr(){

			if (list.Count==0)
			{
				return new nilnul.obj.str_.Sans<T>();
			}
			var head = list.First();
			list.RemoveAt(0);
			return new nilnul.obj.str_.Started<T, StrI<T>>( head, this );

		}
	}
}
