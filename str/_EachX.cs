using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str
{
	static public class _EachX
	{
		static public void Each<T>(this IEnumerable<T> objs, Action<T> action) {
			foreach (T item in objs) action(item);

		}

		static public void Each<T>(this IEnumerable<T> objs, Action<T,int > action) {
			
			foreach (
				var item11 in objs.Select(
					(item, index) => (item,index))
				)
			 action(
				 item11.item, item11.index
			);

		}

	}
}
