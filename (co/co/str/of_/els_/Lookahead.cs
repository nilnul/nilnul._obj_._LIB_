using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co.str.of_
{


	/// <summary>
	/// assume the boxed is a str (finite sequence)
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class _PeekAhead_ovStr<T> :
		nilnul.obj.Box1<IEnumerable<T>>
		,
		IEnumerable<(T,T) >
	{
		public _PeekAhead_ovStr(IEnumerable<T> val) : base(val)
		{

		}


		/// <summary>
		/// enumerate from the current position
		/// </summary>
		/// <returns></returns>
		public IEnumerator<(T, T)> GetEnumerator()
		{
			var enumer = boxed.GetEnumerator();
			T first;

			while (enumer.MoveNext())
			{
				first = enumer.Current;
				if (enumer.MoveNext())
				{
					yield return (first, enumer.Current);
					first = enumer.Current;
				}
				else
				{
					yield break;
				}

			}
			


		}

	

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}


}
