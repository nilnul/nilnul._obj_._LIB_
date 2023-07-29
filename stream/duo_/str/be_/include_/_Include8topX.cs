using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream.duo_.str.be_
{
	/// <summary>
	/// include at top
	/// </summary>
	static public class _Include8topX
	{
		static public bool _Include8top_1str<T>(
			obj.StreamI2<T> seq
			,
			IEnumerable<T> str
			,
			IEqualityComparer<T> eq 
		) {
			foreach (var item in str)
			{
				if (!eq.Equals(item,seq.next() ))
				{
					return false;
				}

			}
			return true;
		}

		static public bool _Include8top_1str<T>(
			obj.StreamI2<T> seq
			,
			IEnumerable<T> str
		) {

			return _Include8top_1str(seq,str, EqualityComparer<T>.Default);
		}

	}
}
