using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq.where_
{
	static public class _NotNulX
	{
		static public IEnumerable<T> NotNul<T>(this IEnumerable<T> seq) {
			return seq.Where(
				x=> !(
					object.ReferenceEquals(x , null)
				)
			);
		}
	}
}