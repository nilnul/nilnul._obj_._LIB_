using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{

	/// <summary>
	/// use clauzes to describe an obj.
	/// </summary>
	public class ClausesX
	{
		/// <summary>
		/// as the separator for sentences/statements in computer programming language such as C#/c/java/js
		/// </summary>
		public const char SEP = ';';
		static public string _Phrase_assumeClauseHasNoSemicolon(
			IEnumerable<string> tags

		) {
			return string.Join(";",tags);
		}
		static public string _Phrase_assumeClauseHasNoSemicolon(
			IEnumerable<object> tags

		) {
			return _Phrase_assumeClauseHasNoSemicolon(tags.Select(o=>o.ToString()));
		}


	}
}
