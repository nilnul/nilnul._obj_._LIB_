using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_
{

	
	[Obsolete()]
	public class Empty<T> :  EmptyI, IEnumerable<T>
	{
		public IEnumerator<T> GetEnumerator()
		{
			yield break;

			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}


}
