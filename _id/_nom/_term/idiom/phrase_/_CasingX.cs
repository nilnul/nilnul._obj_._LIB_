using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._id._nom._term.idiom.phrase_
{
	/// <summary>
	/// idiom is case-insensitive.
	/// to compare it as str, the canonical casing is lowercase
	/// </summary>
	/// <remarks>
	/// note:
	///		even for acronyms, the primary casing is all lower. and only in upper case would it be all upper.
	/// </remarks>
	static public class _CasingX
	{
		/// <summary>
		/// lowercase as the canonical form
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		/// alias:
		///		lower
		static public string Canonic(string x) {
			return x.ToLower();
		}
		static public string Upper(string x) {
			return x.ToUpper();
		}

		/// <summary>
		/// idiom is dwelt
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		static public string _Capital_assumeDwelt(string input) {
			return string.Concat(input[0].ToString().ToUpper(), input.Substring(1));
			//return  x.First().ToUpper();
		}
		public static IEnumerable<char> _Capital_assumeDwelt(IEnumerator<char> enumerable)
		{
			enumerable.MoveNext();
			yield return char.ToUpper( enumerable.Current );
			while (enumerable.MoveNext())
			{
			yield return char.ToLower( enumerable.Current );

			}

		}
		public static IEnumerable<char> _Capital_assumeDwelt(IEnumerable<char> enumerable)
		{

			return _Capital_assumeDwelt(enumerable.GetEnumerator());
		}

		static public string _Tail_assumeDwelt(string input) {

			return  string.Concat( _Capital_assumeDwelt(input.Reverse()).Reverse() );

			//return new string( _Capital_assumeDwelt(input.Reverse()).Reverse().ToArray() );

			//return new StringBuilder( _Capital_assumeDwelt(input.Reverse()).Reverse() );
			
		}

	}

}
