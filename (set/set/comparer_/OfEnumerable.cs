using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set.comparer_
{
	public class OfEnumerable<T>
		: IComparer<IEnumerable<T>>
	{


		public int Compare(IEnumerable<T> x, IEnumerable<T> y)
		{
			throw new NotImplementedException();
		}
	}
}
