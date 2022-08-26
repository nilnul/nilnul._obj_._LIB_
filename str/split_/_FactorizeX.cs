using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.split_
{
	/// <summary>
	/// part length is positive and can divide the length of the whole without remainder.
	/// </summary>
	static public class _FactorizeX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="str">length can be nil</param>
		/// <param name="_partLengthAssumePositiveFactor">positive, also can divide the length of the whole str without remainder</param>
		/// <returns>
		/// a collection of arr, each of which has the same length as given by <paramref name="_partLengthAssumePositiveFactor"/>
		/// </returns>
		static public IEnumerable<T[]> _Factorize_partLengthAssumeFactor<T>(this T[] str, int _partLengthAssumePositiveFactor)
		{

			for (int j = 0; j < str.Length;)
			{
				var part = new T[_partLengthAssumePositiveFactor];
				for (int i = 0; i < _partLengthAssumePositiveFactor; i++, j++)
				{
					part[i] = str[j];
				}
				yield return part;
			}

		}

		static public IEnumerable<T[]> _Factorize_partLengthAssumeFactor<T>(this IEnumerator<T> enumerator, int _partLengthAssumePositiveFactor)
		{
			while (enumerator.MoveNext())
			{
				var part = new T[_partLengthAssumePositiveFactor];
				part[0] = enumerator.Current;
				for (int j = 1; j < _partLengthAssumePositiveFactor; j++)
				{
					enumerator.MoveNext();
					part[j] = enumerator.Current;
				}
				yield return part;
			}
		}

		static public IEnumerable<T[]> _Factorize_partLengthAssumeFactor<T>(this IEnumerable<T> str, int _partLengthAssumePositiveFactor)
		{
			return _Factorize_partLengthAssumeFactor(
				str.GetEnumerator()
				, _partLengthAssumePositiveFactor
			);
		}


	}
}