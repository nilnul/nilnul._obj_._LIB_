using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._seq_
{
	static public class GetEnumeratorIX
	{

		static public IEnumerator GetEnumerator<T>(IEnumerable<T> seq)
		{
			return seq.GetEnumerator();
		}

	}

	[Serializable]
	public abstract class GetEnumeratorA<T> : IEnumerable<T>
	{
		public abstract IEnumerator<T> GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}







}
