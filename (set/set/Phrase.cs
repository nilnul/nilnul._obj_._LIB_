using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set
{
	static public class PhraseX
	{
		static public string Phrase(HashSet<string> set) {

			return $"{{{  nilnul.objs._PhraseX._Phrase(set)}}}";

		}

		static public string Phrase<T>(IEnumerable<T> set) {

			return $"{{{ nilnul.objs._PhraseX._Phrase(set)}}}";

		}
		

	}
}
