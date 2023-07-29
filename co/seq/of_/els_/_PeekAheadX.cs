using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co.seq.of_.els_
{


	/// <summary>
	/// assume the boxed is a str (finite sequence)
	/// </summary>
	/// <typeparam name="T"></typeparam>
	static public class _PeekAheadX
	{
	

		/// <summary>
		/// enumerate from the current position
		/// </summary>
		/// <returns></returns>
		static public IEnumerator<( T,  T)> CosAsEnumer<T>(
			//in
			IEnumerable<T> els
		)
		{
			var enumer = els.GetEnumerator();
			T first;

			while (enumer.MoveNext())
			{
				first = enumer.Current;
				if (enumer.MoveNext())
				{
					yield return  ( first,  enumer.Current);
					first = enumer.Current;
				}
				else
				{
					yield break;
				}

			}

		}

		static public IEnumerable<( T,  T)> Cos<T>(
			//in
			IEnumerable<T> els
		)
		{
			var enumer = els.GetEnumerator();
			T first;

			while (enumer.MoveNext())
			{
				first = enumer.Current;
				if (enumer.MoveNext())
				{
					yield return  ( first,  enumer.Current);
					first = enumer.Current;
				}
				else
				{
					yield break;
				}

			}

		}

	
	}


}
