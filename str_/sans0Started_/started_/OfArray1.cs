using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.started_
{
	public class OfArr<T> :
		nilnul.obj.str.be_.started.vow.en_.OfArr<T>
		,
		IEnumerable<T>
	{

		public OfArr(T[] list):base(list)
		{
			
		}

		public IEnumerator<T> GetEnumerator()
		{
			return this.en.AsEnumerable<T>().GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator(); ;
		}
	}
}
