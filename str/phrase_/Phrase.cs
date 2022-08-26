using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace nilnul.obj.str
{

	/// <summary>
	/// different from nilnul.objs.Phrase, "[]" is enveloping.
	/// </summary>
	/// <remarks>
	/// for sortie/tuple,
	///		"(angelar)(closingAngular)"
	///	for set: "{}"
	///	for str: "[]"
	///	for objs "a,b,c"   (no enclosing mark)
	/// </remarks>
	static public  class _PhraseX
	{

		public const string SEPERATOR = ",";

		

		static public string Phrase<T>(this IEnumerable<T> vector, string seperator=SEPERATOR)
		{
			return  $"[{nilnul.objs._PhraseX._Phrase(vector,SEPERATOR) }]";

		}


		static public string Phrase<T>(this IEnumerable<T> vector, char seperator)
		{
			
				return Phrase(vector, seperator.ToString());

		}
		static public string Lines<T>(this IEnumerable<T> vector)
		{
			return Phrase(vector, Environment.NewLine);

		}


	}
}
