using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace nilnul.obj.str
{

	/// <summary>
	
	/// </summary>
	///
	[Obsolete()]
	static public  class PhraseX
	{

		public const string SEPERATOR = ",";

		

		static public string Phrase<T>(this IEnumerable<T> vector, string seperator=SEPERATOR)
		{
			if (vector.Any())
			{
				return nilnul.str_.started.X._ToTxt_byLoop(vector,seperator);

			}
			return "";

		}


		static public string Phrase<T>(this IEnumerable<T> vector, char seperator)
		{
			
			return string.Join(seperator.ToString(),vector);

		}
		static public string Lines<T>(this IEnumerable<T> vector)
		{
			return Phrase(vector, Environment.NewLine);

		}


	}
}
