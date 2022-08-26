using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs
{
	static public class _PhraseX
	{
		static public string _Phrase<T>(IEnumerable<T> objs, string sep=",") {
			return string.Join(sep, objs);
		}
		static public string _Phrase<T>(IEnumerable<T> objs, char sep) {
			return _Phrase(objs,sep.ToString());
		}

		static public string _PhraseAsLines<T>(IEnumerable<T> objs) {
			return _Phrase(objs,Environment.NewLine);
		}

	}
}
